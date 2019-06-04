namespace Weighbridge
{
    partial class SettingsForm
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
            this.portNameLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.handshakeLabel = new System.Windows.Forms.Label();
            this.databaseDirectoryLabel = new System.Windows.Forms.Label();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.handshakeComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.databaseDirectoryButton = new System.Windows.Forms.Button();
            this.databaseDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portNameLabel.Location = new System.Drawing.Point(10, 13);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(75, 23);
            this.portNameLabel.TabIndex = 14;
            this.portNameLabel.Text = "Port Adı";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baudRateLabel.Location = new System.Drawing.Point(10, 53);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(94, 23);
            this.baudRateLabel.TabIndex = 15;
            this.baudRateLabel.Text = "Baud Rate";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parityLabel.Location = new System.Drawing.Point(10, 93);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(60, 23);
            this.parityLabel.TabIndex = 16;
            this.parityLabel.Text = "Parity";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataBitsLabel.Location = new System.Drawing.Point(10, 133);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(84, 23);
            this.dataBitsLabel.TabIndex = 17;
            this.dataBitsLabel.Text = "Data Bits";
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopBitsLabel.Location = new System.Drawing.Point(10, 173);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(84, 23);
            this.stopBitsLabel.TabIndex = 18;
            this.stopBitsLabel.Text = "Stop Bits";
            // 
            // handshakeLabel
            // 
            this.handshakeLabel.AutoSize = true;
            this.handshakeLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.handshakeLabel.Location = new System.Drawing.Point(10, 213);
            this.handshakeLabel.Name = "handshakeLabel";
            this.handshakeLabel.Size = new System.Drawing.Size(105, 23);
            this.handshakeLabel.TabIndex = 19;
            this.handshakeLabel.Text = "Handshake";
            // 
            // databaseDirectoryLabel
            // 
            this.databaseDirectoryLabel.AutoSize = true;
            this.databaseDirectoryLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.databaseDirectoryLabel.Location = new System.Drawing.Point(10, 253);
            this.databaseDirectoryLabel.Name = "databaseDirectoryLabel";
            this.databaseDirectoryLabel.Size = new System.Drawing.Size(145, 23);
            this.databaseDirectoryLabel.TabIndex = 20;
            this.databaseDirectoryLabel.Text = "Veritabanı Dizini";
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.portNameComboBox.Location = new System.Drawing.Point(200, 10);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(121, 31);
            this.portNameComboBox.TabIndex = 21;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "75",
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.baudRateComboBox.Location = new System.Drawing.Point(200, 50);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 31);
            this.baudRateComboBox.TabIndex = 22;
            // 
            // parityComboBox
            // 
            this.parityComboBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityComboBox.Location = new System.Drawing.Point(200, 90);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(121, 31);
            this.parityComboBox.TabIndex = 23;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.dataBitsComboBox.Location = new System.Drawing.Point(200, 130);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(121, 31);
            this.dataBitsComboBox.TabIndex = 24;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive",
            "None"});
            this.stopBitsComboBox.Location = new System.Drawing.Point(200, 170);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(121, 31);
            this.stopBitsComboBox.TabIndex = 25;
            // 
            // handshakeComboBox
            // 
            this.handshakeComboBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.handshakeComboBox.FormattingEnabled = true;
            this.handshakeComboBox.Items.AddRange(new object[] {
            "None",
            "RequestToSend",
            "RequestToSendXOnXOff",
            "XOnXOff"});
            this.handshakeComboBox.Location = new System.Drawing.Point(200, 210);
            this.handshakeComboBox.Name = "handshakeComboBox";
            this.handshakeComboBox.Size = new System.Drawing.Size(121, 31);
            this.handshakeComboBox.TabIndex = 26;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // databaseDirectoryButton
            // 
            this.databaseDirectoryButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.databaseDirectoryButton.Location = new System.Drawing.Point(327, 250);
            this.databaseDirectoryButton.Name = "databaseDirectoryButton";
            this.databaseDirectoryButton.Size = new System.Drawing.Size(30, 30);
            this.databaseDirectoryButton.TabIndex = 27;
            this.databaseDirectoryButton.Text = "...";
            this.databaseDirectoryButton.UseVisualStyleBackColor = true;
            this.databaseDirectoryButton.Click += new System.EventHandler(this.databaseDirectoryButton_Click);
            // 
            // databaseDirectoryTextBox
            // 
            this.databaseDirectoryTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.databaseDirectoryTextBox.Location = new System.Drawing.Point(200, 250);
            this.databaseDirectoryTextBox.Name = "databaseDirectoryTextBox";
            this.databaseDirectoryTextBox.Size = new System.Drawing.Size(121, 30);
            this.databaseDirectoryTextBox.TabIndex = 28;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveSettingsButton.Location = new System.Drawing.Point(14, 312);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(77, 35);
            this.saveSettingsButton.TabIndex = 29;
            this.saveSettingsButton.Text = "Kaydet";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // defaultButton
            // 
            this.defaultButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.defaultButton.Location = new System.Drawing.Point(298, 312);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(112, 35);
            this.defaultButton.TabIndex = 30;
            this.defaultButton.Text = "Varsayılan";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 359);
            this.Controls.Add(this.defaultButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.databaseDirectoryTextBox);
            this.Controls.Add(this.databaseDirectoryButton);
            this.Controls.Add(this.handshakeComboBox);
            this.Controls.Add(this.stopBitsComboBox);
            this.Controls.Add(this.dataBitsComboBox);
            this.Controls.Add(this.parityComboBox);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.portNameComboBox);
            this.Controls.Add(this.databaseDirectoryLabel);
            this.Controls.Add(this.handshakeLabel);
            this.Controls.Add(this.stopBitsLabel);
            this.Controls.Add(this.dataBitsLabel);
            this.Controls.Add(this.parityLabel);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.portNameLabel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.Label handshakeLabel;
        private System.Windows.Forms.Label databaseDirectoryLabel;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.ComboBox handshakeComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button databaseDirectoryButton;
        private System.Windows.Forms.TextBox databaseDirectoryTextBox;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button defaultButton;
    }
}