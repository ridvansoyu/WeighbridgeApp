namespace Weighbridge{
    partial class WeighBridgeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeighBridgeForm));
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketNoText = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.previewButton = new System.Windows.Forms.Button();
            this.pageSettingsButton = new System.Windows.Forms.Button();
            this.ticketNoLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.grossWeightLabel = new System.Windows.Forms.Label();
            this.tareWeightLabel = new System.Windows.Forms.Label();
            this.netWeightLabel = new System.Windows.Forms.Label();
            this.sevenSegmentArray1 = new SevenSegment.SevenSegmentArray();
            this.ledDisplayPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.captureWeightButton = new System.Windows.Forms.Button();
            this.manualRadioButton = new System.Windows.Forms.RadioButton();
            this.autoRadioButton = new System.Windows.Forms.RadioButton();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleText = new System.Windows.Forms.Label();
            this.ticketNoPanel = new System.Windows.Forms.Panel();
            this.weightPanel = new System.Windows.Forms.Panel();
            this.tareWeightRadioButton = new System.Windows.Forms.RadioButton();
            this.grossWeightRadioButton = new System.Windows.Forms.RadioButton();
            this.netWeightTextBox = new System.Windows.Forms.TextBox();
            this.tareWeightTextBox = new System.Windows.Forms.TextBox();
            this.grossWeightTextBox = new System.Windows.Forms.TextBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.operatorTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.driverTextBox = new System.Windows.Forms.TextBox();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.departureDestinationLabel = new System.Windows.Forms.Label();
            this.arrivalDestinationLabel = new System.Windows.Forms.Label();
            this.departureTimeLabel = new System.Windows.Forms.Label();
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.arrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDestinationTextBox = new System.Windows.Forms.TextBox();
            this.departureDestinationTextBox = new System.Windows.Forms.TextBox();
            this.departureTimeTextBox = new System.Windows.Forms.TextBox();
            this.enterExitTimePanel = new System.Windows.Forms.Panel();
            this.queueListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ledDisplayPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.ticketNoPanel.SuspendLayout();
            this.weightPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.enterExitTimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.printButton.Location = new System.Drawing.Point(10, 300);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(125, 30);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Yazdır";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.Location = new System.Drawing.Point(147, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 30);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Çıkış";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ticketNoText
            // 
            this.ticketNoText.Enabled = false;
            this.ticketNoText.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ticketNoText.Location = new System.Drawing.Point(132, 8);
            this.ticketNoText.Name = "ticketNoText";
            this.ticketNoText.Size = new System.Drawing.Size(185, 30);
            this.ticketNoText.TabIndex = 11;
            this.ticketNoText.Enter += new System.EventHandler(this.text_Enter);
            this.ticketNoText.Leave += new System.EventHandler(this.text_Leave);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.previewButton.Location = new System.Drawing.Point(147, 269);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(125, 30);
            this.previewButton.TabIndex = 6;
            this.previewButton.Text = "Baskı Önizleme";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // pageSettingsButton
            // 
            this.pageSettingsButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageSettingsButton.Location = new System.Drawing.Point(10, 269);
            this.pageSettingsButton.Name = "pageSettingsButton";
            this.pageSettingsButton.Size = new System.Drawing.Size(125, 30);
            this.pageSettingsButton.TabIndex = 5;
            this.pageSettingsButton.Text = "Sayfa Ayarları";
            this.pageSettingsButton.UseVisualStyleBackColor = true;
            this.pageSettingsButton.Click += new System.EventHandler(this.pageSettingsButton_Click);
            // 
            // ticketNoLabel
            // 
            this.ticketNoLabel.AutoSize = true;
            this.ticketNoLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ticketNoLabel.Location = new System.Drawing.Point(3, 11);
            this.ticketNoLabel.Name = "ticketNoLabel";
            this.ticketNoLabel.Size = new System.Drawing.Size(90, 23);
            this.ticketNoLabel.TabIndex = 13;
            this.ticketNoLabel.Text = "Ölçüm No";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carLabel.Location = new System.Drawing.Point(3, 14);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(58, 23);
            this.carLabel.TabIndex = 16;
            this.carLabel.Text = "Plaka";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyLabel.Location = new System.Drawing.Point(3, 86);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(60, 23);
            this.companyLabel.TabIndex = 17;
            this.companyLabel.Text = "Firma";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialLabel.Location = new System.Drawing.Point(3, 126);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(86, 23);
            this.materialLabel.TabIndex = 18;
            this.materialLabel.Text = "Malzeme";
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.operatorLabel.Location = new System.Drawing.Point(3, 162);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(84, 23);
            this.operatorLabel.TabIndex = 19;
            this.operatorLabel.Text = "Operatör";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLabel.Location = new System.Drawing.Point(3, 50);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(56, 23);
            this.driverLabel.TabIndex = 22;
            this.driverLabel.Text = "Şoför";
            // 
            // grossWeightLabel
            // 
            this.grossWeightLabel.AutoSize = true;
            this.grossWeightLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grossWeightLabel.Location = new System.Drawing.Point(26, 11);
            this.grossWeightLabel.Name = "grossWeightLabel";
            this.grossWeightLabel.Size = new System.Drawing.Size(47, 23);
            this.grossWeightLabel.TabIndex = 25;
            this.grossWeightLabel.Text = "Brüt";
            // 
            // tareWeightLabel
            // 
            this.tareWeightLabel.AutoSize = true;
            this.tareWeightLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tareWeightLabel.Location = new System.Drawing.Point(26, 47);
            this.tareWeightLabel.Name = "tareWeightLabel";
            this.tareWeightLabel.Size = new System.Drawing.Size(50, 23);
            this.tareWeightLabel.TabIndex = 26;
            this.tareWeightLabel.Text = "Dara";
            // 
            // netWeightLabel
            // 
            this.netWeightLabel.AutoSize = true;
            this.netWeightLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.netWeightLabel.Location = new System.Drawing.Point(26, 83);
            this.netWeightLabel.Name = "netWeightLabel";
            this.netWeightLabel.Size = new System.Drawing.Size(39, 23);
            this.netWeightLabel.TabIndex = 27;
            this.netWeightLabel.Text = "Net";
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 7;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Chartreuse;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(6, 3);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(607, 114);
            this.sevenSegmentArray1.TabIndex = 29;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = null;
            // 
            // ledDisplayPanel
            // 
            this.ledDisplayPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.ledDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ledDisplayPanel.Controls.Add(this.settingsButton);
            this.ledDisplayPanel.Controls.Add(this.captureWeightButton);
            this.ledDisplayPanel.Controls.Add(this.manualRadioButton);
            this.ledDisplayPanel.Controls.Add(this.autoRadioButton);
            this.ledDisplayPanel.Controls.Add(this.sevenSegmentArray1);
            this.ledDisplayPanel.Location = new System.Drawing.Point(2, 41);
            this.ledDisplayPanel.Name = "ledDisplayPanel";
            this.ledDisplayPanel.Size = new System.Drawing.Size(621, 156);
            this.ledDisplayPanel.TabIndex = 30;
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(581, 120);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(32, 32);
            this.settingsButton.TabIndex = 33;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // captureWeightButton
            // 
            this.captureWeightButton.BackColor = System.Drawing.Color.AliceBlue;
            this.captureWeightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.captureWeightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.captureWeightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.captureWeightButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.captureWeightButton.ForeColor = System.Drawing.Color.Red;
            this.captureWeightButton.Location = new System.Drawing.Point(254, 119);
            this.captureWeightButton.Name = "captureWeightButton";
            this.captureWeightButton.Size = new System.Drawing.Size(108, 35);
            this.captureWeightButton.TabIndex = 32;
            this.captureWeightButton.Text = "Tartım Yap";
            this.captureWeightButton.UseVisualStyleBackColor = false;
            this.captureWeightButton.Click += new System.EventHandler(this.captureWeightButton_Click);
            // 
            // manualRadioButton
            // 
            this.manualRadioButton.AutoSize = true;
            this.manualRadioButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manualRadioButton.Location = new System.Drawing.Point(107, 123);
            this.manualRadioButton.Name = "manualRadioButton";
            this.manualRadioButton.Size = new System.Drawing.Size(63, 23);
            this.manualRadioButton.TabIndex = 31;
            this.manualRadioButton.TabStop = true;
            this.manualRadioButton.Text = "El İle";
            this.manualRadioButton.UseVisualStyleBackColor = true;
            this.manualRadioButton.CheckedChanged += new System.EventHandler(this.manualRadioButton_CheckedChanged);
            // 
            // autoRadioButton
            // 
            this.autoRadioButton.AutoSize = true;
            this.autoRadioButton.Checked = true;
            this.autoRadioButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.autoRadioButton.Location = new System.Drawing.Point(10, 124);
            this.autoRadioButton.Name = "autoRadioButton";
            this.autoRadioButton.Size = new System.Drawing.Size(91, 23);
            this.autoRadioButton.TabIndex = 30;
            this.autoRadioButton.TabStop = true;
            this.autoRadioButton.Text = "Otomatik";
            this.autoRadioButton.UseVisualStyleBackColor = true;
            this.autoRadioButton.CheckedChanged += new System.EventHandler(this.autoRadioButton_CheckedChanged);
            // 
            // titlePanel
            // 
            this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlePanel.Controls.Add(this.titleText);
            this.titlePanel.Location = new System.Drawing.Point(2, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(621, 36);
            this.titlePanel.TabIndex = 31;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleText.Location = new System.Drawing.Point(197, 5);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(227, 23);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Çoban Oğlu Geri Dönüşüm";
            // 
            // ticketNoPanel
            // 
            this.ticketNoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketNoPanel.Controls.Add(this.ticketNoLabel);
            this.ticketNoPanel.Controls.Add(this.ticketNoText);
            this.ticketNoPanel.Location = new System.Drawing.Point(2, 200);
            this.ticketNoPanel.Name = "ticketNoPanel";
            this.ticketNoPanel.Size = new System.Drawing.Size(328, 49);
            this.ticketNoPanel.TabIndex = 32;
            // 
            // weightPanel
            // 
            this.weightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightPanel.Controls.Add(this.tareWeightRadioButton);
            this.weightPanel.Controls.Add(this.grossWeightRadioButton);
            this.weightPanel.Controls.Add(this.netWeightTextBox);
            this.weightPanel.Controls.Add(this.tareWeightTextBox);
            this.weightPanel.Controls.Add(this.grossWeightTextBox);
            this.weightPanel.Controls.Add(this.grossWeightLabel);
            this.weightPanel.Controls.Add(this.tareWeightLabel);
            this.weightPanel.Controls.Add(this.netWeightLabel);
            this.weightPanel.Location = new System.Drawing.Point(2, 251);
            this.weightPanel.Name = "weightPanel";
            this.weightPanel.Size = new System.Drawing.Size(328, 117);
            this.weightPanel.TabIndex = 33;
            // 
            // tareWeightRadioButton
            // 
            this.tareWeightRadioButton.AutoSize = true;
            this.tareWeightRadioButton.Location = new System.Drawing.Point(6, 53);
            this.tareWeightRadioButton.Name = "tareWeightRadioButton";
            this.tareWeightRadioButton.Size = new System.Drawing.Size(14, 13);
            this.tareWeightRadioButton.TabIndex = 31;
            this.tareWeightRadioButton.TabStop = true;
            this.tareWeightRadioButton.UseVisualStyleBackColor = true;
            // 
            // grossWeightRadioButton
            // 
            this.grossWeightRadioButton.AutoSize = true;
            this.grossWeightRadioButton.Checked = true;
            this.grossWeightRadioButton.Location = new System.Drawing.Point(6, 17);
            this.grossWeightRadioButton.Name = "grossWeightRadioButton";
            this.grossWeightRadioButton.Size = new System.Drawing.Size(14, 13);
            this.grossWeightRadioButton.TabIndex = 30;
            this.grossWeightRadioButton.TabStop = true;
            this.grossWeightRadioButton.UseVisualStyleBackColor = true;
            // 
            // netWeightTextBox
            // 
            this.netWeightTextBox.Enabled = false;
            this.netWeightTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.netWeightTextBox.Location = new System.Drawing.Point(132, 80);
            this.netWeightTextBox.Name = "netWeightTextBox";
            this.netWeightTextBox.Size = new System.Drawing.Size(185, 30);
            this.netWeightTextBox.TabIndex = 29;
            this.netWeightTextBox.Text = "0 kg";
            this.netWeightTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.netWeightTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // tareWeightTextBox
            // 
            this.tareWeightTextBox.Enabled = false;
            this.tareWeightTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tareWeightTextBox.Location = new System.Drawing.Point(132, 44);
            this.tareWeightTextBox.Name = "tareWeightTextBox";
            this.tareWeightTextBox.Size = new System.Drawing.Size(185, 30);
            this.tareWeightTextBox.TabIndex = 28;
            this.tareWeightTextBox.Text = "0 kg";
            this.tareWeightTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.tareWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tareWeightTextBox_KeyPress);
            this.tareWeightTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // grossWeightTextBox
            // 
            this.grossWeightTextBox.Enabled = false;
            this.grossWeightTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grossWeightTextBox.Location = new System.Drawing.Point(132, 8);
            this.grossWeightTextBox.Name = "grossWeightTextBox";
            this.grossWeightTextBox.Size = new System.Drawing.Size(185, 30);
            this.grossWeightTextBox.TabIndex = 14;
            this.grossWeightTextBox.Text = "0 kg";
            this.grossWeightTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.grossWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grossWeightTextBox_KeyPress);
            this.grossWeightTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.clearButton);
            this.infoPanel.Controls.Add(this.saveButton);
            this.infoPanel.Controls.Add(this.operatorTextBox);
            this.infoPanel.Controls.Add(this.materialTextBox);
            this.infoPanel.Controls.Add(this.companyTextBox);
            this.infoPanel.Controls.Add(this.driverTextBox);
            this.infoPanel.Controls.Add(this.carTextBox);
            this.infoPanel.Controls.Add(this.carLabel);
            this.infoPanel.Controls.Add(this.exitButton);
            this.infoPanel.Controls.Add(this.companyLabel);
            this.infoPanel.Controls.Add(this.printButton);
            this.infoPanel.Controls.Add(this.materialLabel);
            this.infoPanel.Controls.Add(this.previewButton);
            this.infoPanel.Controls.Add(this.driverLabel);
            this.infoPanel.Controls.Add(this.pageSettingsButton);
            this.infoPanel.Controls.Add(this.operatorLabel);
            this.infoPanel.Location = new System.Drawing.Point(336, 200);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(287, 334);
            this.infoPanel.TabIndex = 35;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Location = new System.Drawing.Point(147, 233);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 30);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Sıfırla";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(10, 233);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 30);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Kaydet";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // operatorTextBox
            // 
            this.operatorTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.operatorTextBox.Location = new System.Drawing.Point(94, 155);
            this.operatorTextBox.Name = "operatorTextBox";
            this.operatorTextBox.Size = new System.Drawing.Size(185, 30);
            this.operatorTextBox.TabIndex = 26;
            this.operatorTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.operatorTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // materialTextBox
            // 
            this.materialTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialTextBox.Location = new System.Drawing.Point(94, 119);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(185, 30);
            this.materialTextBox.TabIndex = 25;
            this.materialTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.materialTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // companyTextBox
            // 
            this.companyTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyTextBox.Location = new System.Drawing.Point(94, 83);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(185, 30);
            this.companyTextBox.TabIndex = 24;
            this.companyTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.companyTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // driverTextBox
            // 
            this.driverTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driverTextBox.Location = new System.Drawing.Point(94, 47);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.Size = new System.Drawing.Size(185, 30);
            this.driverTextBox.TabIndex = 23;
            this.driverTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.driverTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // carTextBox
            // 
            this.carTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carTextBox.Location = new System.Drawing.Point(94, 11);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(185, 30);
            this.carTextBox.TabIndex = 14;
            this.carTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.carTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // departureDestinationLabel
            // 
            this.departureDestinationLabel.AutoSize = true;
            this.departureDestinationLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departureDestinationLabel.Location = new System.Drawing.Point(3, 117);
            this.departureDestinationLabel.Name = "departureDestinationLabel";
            this.departureDestinationLabel.Size = new System.Drawing.Size(87, 23);
            this.departureDestinationLabel.TabIndex = 21;
            this.departureDestinationLabel.Text = "Gidiş Yeri";
            // 
            // arrivalDestinationLabel
            // 
            this.arrivalDestinationLabel.AutoSize = true;
            this.arrivalDestinationLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arrivalDestinationLabel.Location = new System.Drawing.Point(4, 45);
            this.arrivalDestinationLabel.Name = "arrivalDestinationLabel";
            this.arrivalDestinationLabel.Size = new System.Drawing.Size(88, 23);
            this.arrivalDestinationLabel.TabIndex = 20;
            this.arrivalDestinationLabel.Text = "Geliş Yeri";
            // 
            // departureTimeLabel
            // 
            this.departureTimeLabel.AutoSize = true;
            this.departureTimeLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departureTimeLabel.Location = new System.Drawing.Point(3, 81);
            this.departureTimeLabel.Name = "departureTimeLabel";
            this.departureTimeLabel.Size = new System.Drawing.Size(117, 23);
            this.departureTimeLabel.TabIndex = 24;
            this.departureTimeLabel.Text = "Gidiş Zamanı";
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arrivalTimeLabel.Location = new System.Drawing.Point(4, 9);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(118, 23);
            this.arrivalTimeLabel.TabIndex = 23;
            this.arrivalTimeLabel.Text = "Geliş Zamanı";
            // 
            // arrivalTimeTextBox
            // 
            this.arrivalTimeTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arrivalTimeTextBox.Location = new System.Drawing.Point(132, 9);
            this.arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            this.arrivalTimeTextBox.Size = new System.Drawing.Size(185, 30);
            this.arrivalTimeTextBox.TabIndex = 30;
            this.arrivalTimeTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.arrivalTimeTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // arrivalDestinationTextBox
            // 
            this.arrivalDestinationTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arrivalDestinationTextBox.Location = new System.Drawing.Point(132, 45);
            this.arrivalDestinationTextBox.Name = "arrivalDestinationTextBox";
            this.arrivalDestinationTextBox.Size = new System.Drawing.Size(185, 30);
            this.arrivalDestinationTextBox.TabIndex = 31;
            this.arrivalDestinationTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.arrivalDestinationTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // departureDestinationTextBox
            // 
            this.departureDestinationTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departureDestinationTextBox.Location = new System.Drawing.Point(132, 117);
            this.departureDestinationTextBox.Name = "departureDestinationTextBox";
            this.departureDestinationTextBox.Size = new System.Drawing.Size(185, 30);
            this.departureDestinationTextBox.TabIndex = 32;
            this.departureDestinationTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.departureDestinationTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // departureTimeTextBox
            // 
            this.departureTimeTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departureTimeTextBox.Location = new System.Drawing.Point(132, 81);
            this.departureTimeTextBox.Name = "departureTimeTextBox";
            this.departureTimeTextBox.Size = new System.Drawing.Size(185, 30);
            this.departureTimeTextBox.TabIndex = 33;
            this.departureTimeTextBox.Enter += new System.EventHandler(this.text_Enter);
            this.departureTimeTextBox.Leave += new System.EventHandler(this.text_Leave);
            // 
            // enterExitTimePanel
            // 
            this.enterExitTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterExitTimePanel.Controls.Add(this.departureTimeTextBox);
            this.enterExitTimePanel.Controls.Add(this.departureDestinationTextBox);
            this.enterExitTimePanel.Controls.Add(this.arrivalDestinationTextBox);
            this.enterExitTimePanel.Controls.Add(this.arrivalTimeTextBox);
            this.enterExitTimePanel.Controls.Add(this.arrivalTimeLabel);
            this.enterExitTimePanel.Controls.Add(this.departureTimeLabel);
            this.enterExitTimePanel.Controls.Add(this.arrivalDestinationLabel);
            this.enterExitTimePanel.Controls.Add(this.departureDestinationLabel);
            this.enterExitTimePanel.Location = new System.Drawing.Point(2, 373);
            this.enterExitTimePanel.Name = "enterExitTimePanel";
            this.enterExitTimePanel.Size = new System.Drawing.Size(328, 161);
            this.enterExitTimePanel.TabIndex = 34;
            // 
            // queueListView
            // 
            this.queueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.queueListView.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.queueListView.FullRowSelect = true;
            this.queueListView.Location = new System.Drawing.Point(2, 540);
            this.queueListView.Name = "queueListView";
            this.queueListView.Size = new System.Drawing.Size(621, 139);
            this.queueListView.TabIndex = 36;
            this.queueListView.UseCompatibleStateImageBehavior = false;
            this.queueListView.View = System.Windows.Forms.View.Details;
            this.queueListView.DoubleClick += new System.EventHandler(this.listview_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaka";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Geliş Zamanı";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Brüt";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 100;
            // 
            // WeighBridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(629, 683);
            this.Controls.Add(this.queueListView);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.enterExitTimePanel);
            this.Controls.Add(this.weightPanel);
            this.Controls.Add(this.ticketNoPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.ledDisplayPanel);
            this.Name = "WeighBridgeForm";
            this.Text = "Çobanoğlu Geri Dönüşüm Kantar Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ledDisplayPanel.ResumeLayout(false);
            this.ledDisplayPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ticketNoPanel.ResumeLayout(false);
            this.ticketNoPanel.PerformLayout();
            this.weightPanel.ResumeLayout(false);
            this.weightPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.enterExitTimePanel.ResumeLayout(false);
            this.enterExitTimePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox ticketNoText;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button pageSettingsButton;
        private System.Windows.Forms.Label ticketNoLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label grossWeightLabel;
        private System.Windows.Forms.Label tareWeightLabel;
        private System.Windows.Forms.Label netWeightLabel;
        private SevenSegment.SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.Panel ledDisplayPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Button captureWeightButton;
        private System.Windows.Forms.RadioButton manualRadioButton;
        private System.Windows.Forms.RadioButton autoRadioButton;
        private System.Windows.Forms.Panel ticketNoPanel;
        private System.Windows.Forms.Panel weightPanel;
        private System.Windows.Forms.TextBox netWeightTextBox;
        private System.Windows.Forms.TextBox tareWeightTextBox;
        private System.Windows.Forms.TextBox grossWeightTextBox;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label departureDestinationLabel;
        private System.Windows.Forms.Label arrivalDestinationLabel;
        private System.Windows.Forms.Label departureTimeLabel;
        private System.Windows.Forms.Label arrivalTimeLabel;
        private System.Windows.Forms.TextBox arrivalTimeTextBox;
        private System.Windows.Forms.TextBox arrivalDestinationTextBox;
        private System.Windows.Forms.TextBox departureDestinationTextBox;
        private System.Windows.Forms.TextBox departureTimeTextBox;
        private System.Windows.Forms.Panel enterExitTimePanel;
        private System.Windows.Forms.TextBox operatorTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox driverTextBox;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.RadioButton tareWeightRadioButton;
        private System.Windows.Forms.RadioButton grossWeightRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView queueListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button settingsButton;
    }
}

