using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO.Ports;
using System.Threading;
using System.Drawing.Printing;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Weighbridge
{
    public partial class WeighBridgeForm : Form
    {
        #region Form and Application Default Settings
        // Create DateTime variable for arrival and departure times
        DateTime CurrentDate;
        // Create Serial Port variable for handling serial port data
        SerialPort _serialPort;
        // Control which one (gross or tare) will measured, default is gross
        bool captured = true;
        // Weight integer value, this will keep weight value that came from weightbridge
        int weight = 0;
        // Keep the data that is from weightbridge in this variable
        string weightString = String.Empty;
        // Weight data string with kg unit
        string weightStringKG = String.Empty;
        // Search the received weightbridge buffer and crop the weight values
        string bufferString = String.Empty;

        // gross, tare and net weight integer values, keep this integer values for calculations
        int grossWeight = 0, tareWeight = 0, netWeight = 0;

        // Create config command to use open and get config file values
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        // Create Database Connection and Command
        OleDbConnection connection;
        OleDbCommand command;
        HelperFunction helperFunc = new HelperFunction();
        public WeighBridgeForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // First active control when the form load
            this.ActiveControl = captureWeightButton;

            // Open COM port and read data from weighbridge
            SerialPortProcess();

            // Initialize the page that will be print
            PrintPage();

            // Set Database Connection, Get Database Directory from Config file
            connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + config.AppSettings.Settings["DatabaseDirectory"].Value.ToString());

            GetLastTicketNo();
        }
        #endregion

        #region Serial Port Properties
        public void SerialPortProcess()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            // all of the options for a serial device
            // can be sent through the constructor of the SerialPort class
            // PortName = "COM1", Baud Rate = 19200, Parity = None, 
            // Data Bits = 8, Stop Bits = One, Handshake = None

            // Create an instance of SerialPort
            _serialPort = new SerialPort();

            try
            {
                // Get the configurations for SerialPort from config file
                _serialPort.PortName = config.AppSettings.Settings["PortName"].Value.ToString();
                _serialPort.BaudRate = Convert.ToInt32(config.AppSettings.Settings["BaudRate"].Value);
                _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), config.AppSettings.Settings["Parity"].Value.ToString(), true);
                _serialPort.DataBits = Convert.ToInt32(config.AppSettings.Settings["DataBits"].Value);
                _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), config.AppSettings.Settings["StopBits"].Value.ToString(), true);
                _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), config.AppSettings.Settings["Handshake"].Value.ToString(), true);
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                helperFunc.CreateMessageBox(e.ParamName + " değeri geçerli aralığın dışındaydı. Lütfen ayarlardan " + e.ParamName + " değerini kontrol edin.");
            }

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);

            try
            {
                _serialPort.Open();
            }
            catch (System.UnauthorizedAccessException)
            {
                helperFunc.CreateMessageBox("Seri port açılırken bir hata meydana geldi. Başka bir uygulama seri portu kullanıyor olabilir.");
                _serialPort.Close();
                _serialPort.Dispose();
                _serialPort.Open();
            }
            catch (System.IO.IOException)
            {
                helperFunc.CreateMessageBox("COM1 Bağlantı noktası bulunamadı. " +
                                "Program açılacaktır fakat kantar verisi görüntülenmeyecektir. " +
                                "Lütfen kabloyu ve bağlantı noktası adını kontrol edin.");
            }

        }
        #endregion

        #region Serial Port Data Receive Function
        void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            // https://code.msdn.microsoft.com/windowsdesktop/SerialPort-brief-Example-ac0d5004
            // Initialize a buffer which has a size of Port buffer [4096] to hold the received data 
            byte[] buffer = new byte[_serialPort.ReadBufferSize];

            // Fill the buffer with received data 
            int bytesRead = _serialPort.Read(buffer, 0, buffer.Length);

            // Assume the data we are received is ASCII data. 
            weightString = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            // Store the value of previous weight value for comparison with new one
            // If the weight value is equal to previous weight value, then stay idle
            string tempString = String.Empty;

            // Search the buffer for finding weight numbers byte by byte 
            for (int i = 0; i < buffer.Length - 2; i++)
            {
                // If the character is "+" (ASCII 43), then initialize the reading of weight
                if (buffer[i] == 43)
                {
                    i++;
                    for (i = i; buffer[i] != 43 && i < buffer.Length - 1; i++)
                    {
                        // Search digits and dot character in buffer, digits in ASCII table exist in [48, 57] interval, dot is 46 in ASCII
                        if (buffer[i] > 47 && buffer[i] < 58 || buffer[i] == 46)
                        {
                            bufferString += char.ConvertFromUtf32(buffer[i]);
                        }
                    }
                    // Display shows 0.0005 when the weight is 0, FIX it manually
                    if (bufferString == "0.0005")
                        bufferString = "0.000";

                    // If the bufferString has a new value, then change it with new one
                    if (bufferString != tempString)
                        tempString = bufferString;

                    // Irrelevant data may come from the serial port
                    // To check that it is a weight value, we must control if the bufferString.Length is bigger than 4
                    // Because minimum weight value that come from serial port is 0.000 and it's length is 5
                    if (bufferString.Length > 4)
                    {
                        // Show weight value in the display (Example: display = 15.000)
                        sevenSegmentArray1.Value = bufferString;
                        // Add "kg" to weight value (Example: weightStringKG = 15.000 kg)
                        weightStringKG = AddKG(bufferString);
                        // Delete the "." character (Example: bufferString = "15000")
                        bufferString = bufferString.Replace(".", string.Empty);
                        // Get integer weight value (Example: weight = 15000)
                        weight = Convert.ToInt32(bufferString);

                        // Fix the dot problem (for example: if weight is 250kg, display shows = 0.250 kg, but must be 250 kg
                        if (weight < 1000)
                        {
                            weightStringKG = weightStringKG.TrimStart('0');
                            weightStringKG = weightStringKG.Replace(".", string.Empty);
                            //weightStringKG = bufferString + " kg";
                        }
                        // Clear bufferString for new value
                        bufferString = String.Empty;
                    }
                }
            }
        }
        #endregion

        #region Database Connection (OpenConnection, InsertDatabase, GetLastTicketNo)
        /// <summary>
        /// Open a connection to a database for fetching or inserting data
        /// </summary>
        public void OpenConnection()
        {
            command = connection.CreateCommand();
            try
            {
                connection.Open();
            }
            catch (OleDbException e)
            {
                helperFunc.CreateMessageBox("Veritabanına bağlanırken sorun yaşandı. Bağlantı açık kalmış olabilir veya veritabanı yolu doğru olmayabilir.");
            }
        }

        /// <summary>
        /// Open the database connection and insert the text box values to the database
        /// </summary>
        public void InsertDatabase()
        {
            OpenConnection();

            // Insert the Data and close the connection
            command.CommandText = "Insert into Fatura(Plaka, " +
                "Brut, " +
                "Dara, " +
                "Net," +
                "GelisZamani," +
                "CikisZamani," +
                "Firma)Values('" + carTextBox.Text + "','"
                                    + grossWeightTextBox.Text + "','"
                                    + tareWeightTextBox.Text + "','"
                                    + netWeightTextBox.Text + "','"
                                    + arrivalTimeTextBox.Text + "','"
                                    + departureTimeTextBox.Text + "','"
                                    + companyTextBox.Text + "')";
            command.Connection = connection;
            command.ExecuteNonQuery();
            helperFunc.CreateMessageBox("Veriler Kaydedildi.");
            connection.Close();
        }
        /// <summary>
        /// Get last ticket no and add +1 for ticket no of new record
        /// Set the new ticket no with getting last record's id from database
        /// </summary>
        public void GetLastTicketNo()
        {
            OpenConnection();
            command.CommandText = "SELECT max(ID) from Fatura";
            command.Connection = connection;
            Int32 max = 0;
            try
            {
                max = (Int32)command.ExecuteScalar();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                helperFunc.CreateMessageBox("Son veritabanı kaydının ID'sinin alınması için açık ve kullanılabilen bir Connection gereklidir. Bağlantının geçerli durumu: kapalı.");
            }
            connection.Close();

            // Set the new ticket no
            ticketNoText.Text = (max + 1).ToString();

        }
        #endregion

        #region Enter and Leave Events for Textboxes and Buttons, Clear TextBoxes

        // THIS SECTION EFFECTS ALL TEXT BOXES AND BUTTONS!

        // Enter text box event for changing background color
        private void text_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.LightGreen;
        }

        // Leave text box event for changing background color to default
        private void text_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        //Enter button event for changing button color when the mouse is over button
        public void button_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LemonChiffon;
        }

        // Leave button event for changing button color to default when the mouse cursor is leaved from button
        public void button_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightBlue;
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
        #endregion

        #region Specify Page Size
        private void PrintPage()
        {
            PrinterSettings printerSettings = new PrinterSettings();
            // Page Size is 15.2 x 17 cm
            // Specify custom paper size
            PaperSize paperSize = new PaperSize("Test", 600, 700);
            // Apply new custom paper size
            paperSize.RawKind = (int)PaperKind.Custom;

            // Set new paper size with margins
            printDocument.DefaultPageSettings.PaperSize = paperSize;
            printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            // Set default paper size for printer with margins
            printDocument.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;
            printDocument.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        }
        #endregion

        #region Print and Page Functions
        // Open Print Dialog and select Printer
        private void printButton_Click(object sender, EventArgs e)
        {

            DialogResult pdr = printDialog.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument.Print();

                // After printing process, save the datas to the database,
                // Clear textboxes for new entries, 
                // Set the checkbox,
                // Then get the last id from database for new entry

                InsertDatabase();
                ClearTextBoxes(this.Controls);

                // check gross weight checkbox and auto checkbox
                // clear tare weight checkbox and manual checkbox
                grossWeightRadioButton.Checked = true;
                autoRadioButton.Checked = true;
                GetLastTicketNo();

            }
        }
        // Preview Print Page
        private void previewButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        // Open Page Settings Dialog
        private void pageSettingsButton_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        // Set Print Page
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // To draw a line and set font, create font, brush and pen objects
            Font myFont = new Font("Calibri", 12);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            // Control the coordinates with x and y variables
            int x = 30;
            int y = 30;

            //For Logo
            //e.Graphics.DrawImage(Properties.Resources.logo, 100, 20);

            // Add title of company and set the line to print page  
            e.Graphics.DrawString("ÇOBANOĞLU GERİ DÖNÜŞÜM TESİSAT", myFont, sbrush, x + 130, y);
            y += 30;
            e.Graphics.DrawString("TEL: 0534 353 12 97", myFont, sbrush, x + 185, y);
            y += 30;
            e.Graphics.DrawLine(myPen, x, y, 550, y);
            y += 30;

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString(ticketNoLabel.Text, myFont, sbrush, x, y);
            e.Graphics.DrawString(":", myFont, sbrush, x + 130, y);
            e.Graphics.DrawString(ticketNoText.Text, myFont, sbrush, x + 150, y);
            y += 30;
            e.Graphics.DrawString(carLabel.Text, myFont, sbrush, x, y);
            e.Graphics.DrawString(":", myFont, sbrush, x + 130, y);
            e.Graphics.DrawString(carTextBox.Text, myFont, sbrush, x + 150, y);
            y += 30;
            e.Graphics.DrawString(companyLabel.Text, myFont, sbrush, x, y);
            e.Graphics.DrawString(":", myFont, sbrush, x + 130, y);
            e.Graphics.DrawString(companyTextBox.Text, myFont, sbrush, x + 150, y);
            y += 30;
            e.Graphics.DrawString(arrivalTimeLabel.Text, myFont, sbrush, x, y);
            e.Graphics.DrawString(":", myFont, sbrush, x + 130, y);
            e.Graphics.DrawString(arrivalTimeTextBox.Text, myFont, sbrush, x + 150, y);
            y += 30;
            e.Graphics.DrawString(departureTimeLabel.Text, myFont, sbrush, x, y);
            e.Graphics.DrawString(":", myFont, sbrush, x + 130, y);
            e.Graphics.DrawString(departureTimeTextBox.Text, myFont, sbrush, x + 150, y);
            y += 30;
            e.Graphics.DrawString("Tartım2", myFont, sbrush, x, y);
            e.Graphics.DrawString(":", myFont, sbrush, x + 130, y);
            e.Graphics.DrawString(grossWeightTextBox.Text, myFont, sbrush, x + 150, y);
            y += 30;
            e.Graphics.DrawString("Tartım1", myFont, sbrush, x, y);
            e.Graphics.DrawString(":", myFont, sbrush, x + 130, y);
            e.Graphics.DrawString(tareWeightTextBox.Text, myFont, sbrush, x + 150, y);
            y += 30;
            e.Graphics.DrawString(netWeightLabel.Text, myFont, sbrush, x, y);
            e.Graphics.DrawString(":", myFont, sbrush, x + 130, y);
            e.Graphics.DrawString(netWeightTextBox.Text, myFont, sbrush, x + 150, y);
            y += 30;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;
        }
        #endregion

        #region Helper Functions (AddKG, RemoveKG, AddPoint, CalculateNetWeight)
        /// <summary>
        /// Add " kg" to weight value in the textbox
        /// </summary>
        /// <param name="weightValue">Weight value that will be represent with kg</param>
        /// <returns></returns>
        public String AddKG(String weightValue)
        {
            if (weightValue == String.Empty)
            {
                weightValue = "0";
            }
            weightValue = weightValue + " kg";
            return weightValue;
        }

        /// <summary>
        /// Removes only " kg" from weight value in the textbox
        /// </summary>
        /// <param name="weightValue">Weight value that will be get rid of " kg" postfix</param>
        /// <returns></returns>
        public String RemoveKG(String weightValue)
        {
            weightValue = Regex.Replace(weightValue, "[A-Za-z. ]", "");
            if (weightValue == "0")
            {
                weightValue = String.Empty;
            }
            return weightValue;
        }

        /// <summary>
        /// Add "." to weight value if weightValue >= 1000
        /// </summary>
        /// <param name="targetTextBox">Specify the target textBox.</param>
        /// <param name="weightValue">Specify the weight value.</param>
        public void AddPoint(TextBox targetTextBox, int weightValue)
        {
            CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
            if (weightValue >= 1000 || weightValue <= -1000)
            {
                // Add dot and display it in netWeightTextBox
                targetTextBox.Text = weightValue.ToString("0,0", elGR);
            }
        }

        /// <summary>
        /// Calculates net weight.
        /// </summary>
        /// <param name="gross">gross weight</param>
        /// <param name="tare">tare weight</param>
        public void CalculateNetWeight(int gross, int tare)
        {
            netWeight = gross - tare;

            if (netWeight < 1000)
            {
                netWeightTextBox.Text = AddKG(netWeight.ToString());
            }
            else
            {
                AddPoint(netWeightTextBox, netWeight);
                netWeightTextBox.Text = AddKG(netWeightTextBox.Text);
            }

            if (netWeight < 0)
            {
                AddPoint(netWeightTextBox, netWeight);
                helperFunc.CreateMessageBox("Net Tartım değeri 0'dan küçük olarak ölçüldü. Lütfen tartım değerlerinizi kontrol ediniz.");
            }
        }
        #endregion

        #region Capture Weight Button
        // Capture Weight Button Click Event
        // Auto fill the Date Button for Gross Weight
        // Auto fill the Date Button for Tare Weight
        private void captureWeightButton_Click(object sender, EventArgs e)
        {
            // Create variable for Date and Time
            CurrentDate = DateTime.Now;

            // Control if tareWeightRadioButton is checked
            if (tareWeightRadioButton.Checked)
            {
                captured = false;
            }
            else
            {
                captured = true;
            }

            // Write arrival time and gross weight and check tare weight check box
            if (grossWeightRadioButton.Checked & captured)
            {
                // Get the current date and time and write to the arrivalTimeTextBox
                arrivalTimeTextBox.Text = CurrentDate.ToString();
                // Write the measured gross weight to grossWeightTextBox with KG
                grossWeightTextBox.Text = weightStringKG;
                // Because of the grossweight is just measured, tareWeight must be 0
                tareWeightTextBox.Text = 0 + " kg";
                // tareWeight integer value also must be zero
                tareWeight = 0;
                // grossWeight integer value is measured weight value
                grossWeight = weight;
                // Because of the grossweight is measured, check the tareWeightRadioButton
                tareWeightRadioButton.Checked = true;
            }

            // Write departure time and tare weight and check gross weight checkbox
            if (tareWeightRadioButton.Checked & !captured)
            {
                // Get the current date and time and write to the departureTimeTextBox
                departureTimeTextBox.Text = CurrentDate.ToString();
                // Write the measured tare weight to tareWeightTextBox with KG
                tareWeightTextBox.Text = weightStringKG;
                // tareWeight integer value is measured tareWeight value
                tareWeight = weight;
                // Because of the tareweight is measured, check the grossWeightRadioButton for another measure operation
                grossWeightRadioButton.Checked = true;
            }

            CalculateNetWeight(grossWeight, tareWeight);
        }
        #endregion

        #region Auto and Manual Radio Button's Behaviour
        private void autoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (autoRadioButton.Checked)
            {
                grossWeightTextBox.Enabled = false;
                tareWeightTextBox.Enabled = false;
                netWeightTextBox.Enabled = false;
            }
        }
        private void manualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (manualRadioButton.Checked)
            {
                grossWeightTextBox.Enabled = true;
                tareWeightTextBox.Enabled = true;
                netWeightTextBox.Enabled = true;
            }

            // Add event handler for weight textboxes to add and remove kg, details are in AddKG, RemoveKG and event handlers
            grossWeightTextBox.Enter += GrossWeightTextBox_Enter;
            grossWeightTextBox.Leave += GrossWeightTextBox_Leave;
            tareWeightTextBox.Enter += TareWeightTextBox_Enter;
            tareWeightTextBox.Leave += TareWeightTextBox_Leave;

            // Add event handler for weight textboxes to calculate net weight dynamically
            grossWeightTextBox.TextChanged += TareGrossWeightTextBox_TextChanged;
            tareWeightTextBox.TextChanged += TareGrossWeightTextBox_TextChanged;
        }
        #endregion

        #region Event Handlers for Entering and Leaving Weight TextBoxes
        private void grossWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                this.ActiveControl = tareWeightTextBox;
            }
        }
        private void tareWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                this.ActiveControl = netWeightTextBox;
            }
        }

        // THE EVENT HANDLERS IN THIS SECTION ARE NOT PREDEFINED.
        // THESE ARE WILL BE ADDED AFTER manualRadioButton IS ACTIVE.
        private void GrossWeightTextBox_Enter(object sender, EventArgs e)
        {
            grossWeightTextBox.Text = RemoveKG(grossWeightTextBox.Text);
        }
        private void GrossWeightTextBox_Leave(object sender, EventArgs e)
        {
            if (grossWeightTextBox.Text != String.Empty)
            {
                AddPoint(grossWeightTextBox, Convert.ToInt32(grossWeightTextBox.Text));
            }
            grossWeightTextBox.Text = AddKG(grossWeightTextBox.Text);
        }
        private void TareWeightTextBox_Enter(object sender, EventArgs e)
        {
            tareWeightTextBox.Text = RemoveKG(tareWeightTextBox.Text);
        }
        private void TareWeightTextBox_Leave(object sender, EventArgs e)
        {
            if (tareWeightTextBox.Text != String.Empty)
            {
                AddPoint(tareWeightTextBox, Convert.ToInt32(tareWeightTextBox.Text));
            }
            tareWeightTextBox.Text = AddKG(tareWeightTextBox.Text);
        }
        private void TareGrossWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            // Keep integer value of gross and tare Weight TextBox in this variable
            int gross, tare;
            // RemoveKG function may return String.Empty before convert the text value of tareWeight, so we must check with this temporary string variable
            String weightGross, weightTare;

            // Get the grossWeightText to weightGrosstemporary variable
            weightGross = grossWeightTextBox.Text;
            // Remove the KG, this function also removes any character so the rest of it's value will be Empty or a number
            weightGross = RemoveKG(weightGross);

            // If gross clicked and it's text value is 0, then it's text value will be converted to String.Empty because of GrossWeightTextBox_Enter Event Handler
            // If text value is not zero, then it is a number
            // Check if grossWeight Text is String.Empty or a number
            if (weightGross == String.Empty)
            {
                gross = 0;
            }
            else
            {
                gross = Convert.ToInt32(weightGross);
            }

            // Get the tareWeightText to weightTare temporary variable
            weightTare = tareWeightTextBox.Text;
            // Remove the KG, this function also removes any character so the rest of it's value will be Empty or a number
            weightTare = RemoveKG(weightTare);

            // Control if the tareWeightTextBox is Empty or a number
            if (weightTare == String.Empty)
            {
                tare = 0;
            }
            else
            {
                tare = Convert.ToInt32(weightTare);
            }

            CalculateNetWeight(gross, tare);
        }
        #endregion

        #region ListView Operations
        // When ListView Item is double clicked, fetch the data from listview to textbox
        public void listview_DoubleClick(object sender, EventArgs e)
        {
            // 
            for (int i = 0; i < queueListView.Items.Count; i++)
            {
                // If the list view item is selected
                if (queueListView.Items[i].Selected)
                {
                    // Get the data of zeroth index to the carTextBox
                    carTextBox.Text = queueListView.Items[i].SubItems[0].Text;
                    // Get the data of first index to the arrivatTimeTextBox
                    arrivalTimeTextBox.Text = queueListView.Items[i].SubItems[1].Text;
                    // Get the data of second index to the grossWeightTextBox
                    grossWeightTextBox.Text = queueListView.Items[i].SubItems[2].Text;

                    // When the data fetching is over, remove this row
                    queueListView.SelectedItems[0].Remove();

                    // The data in the list has a value of gross weight, so when the data is fetched, tareWeightRadioButton must be checked
                    tareWeightRadioButton.Checked = true;
                    // And state of captured must be false
                    captured = false;
                }
            }
        }
        #endregion

        #region Save Button
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Pair column data with textbox data
            ListViewItem queue = new ListViewItem(carTextBox.Text); // 1st Column
            queue.SubItems.Add(arrivalTimeTextBox.Text);            // 2nd Column
            queue.SubItems.Add(grossWeightTextBox.Text);            // 3th Column

            // Add textbox data to listview
            queueListView.Items.Add(queue);
        }

        #endregion

        #region Settings Button
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsDialog = new SettingsForm();
            settingsDialog.ShowDialog();
        }
        #endregion

        #region Clear Button
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);

            // TicketNo must not clear, fix this issue with calling GetLastTicketNo function
            GetLastTicketNo();
        }
        #endregion

        #region Exit from Application
        // Exit Application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
