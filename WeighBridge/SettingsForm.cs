using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;

namespace Weighbridge
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            ReadAppSettings();
        }

        string fileDirectory;
        string fileName;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        // Read Application Settings from config file
        public void ReadAppSettings()
        {
            // Get configs values using keys 
            portNameComboBox.Text = config.AppSettings.Settings["PortName"].Value.ToString();
            baudRateComboBox.Text = config.AppSettings.Settings["BaudRate"].Value.ToString();
            parityComboBox.Text = config.AppSettings.Settings["Parity"].Value.ToString();
            dataBitsComboBox.Text = config.AppSettings.Settings["DataBits"].Value.ToString();
            stopBitsComboBox.Text = config.AppSettings.Settings["StopBits"].Value.ToString();
            handshakeComboBox.Text = config.AppSettings.Settings["Handshake"].Value.ToString();
            databaseDirectoryTextBox.Text = config.AppSettings.Settings["DatabaseDirectory"].Value;
        }

        // Get Default App Settings
        public void DefaultAppSettings()
        {
            portNameComboBox.Text = "COM1";
            baudRateComboBox.Text = "9600";
            parityComboBox.Text = "None";
            dataBitsComboBox.Text = "8";
            stopBitsComboBox.Text = "One";
            handshakeComboBox.Text = "None";
        }

        // Update Settings
        public void UpdateAppSettings()
        {
            config.AppSettings.Settings["PortName"].Value = portNameComboBox.Text;
            config.AppSettings.Settings["BaudRate"].Value = baudRateComboBox.Text;
            config.AppSettings.Settings["Parity"].Value = parityComboBox.Text;
            config.AppSettings.Settings["DataBits"].Value = dataBitsComboBox.Text;
            config.AppSettings.Settings["StopBits"].Value = stopBitsComboBox.Text;
            config.AppSettings.Settings["Handshake"].Value = handshakeComboBox.Text;
            config.AppSettings.Settings["DatabaseDirectory"].Value = databaseDirectoryTextBox.Text;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("Ayarlar Kaydedildi! Ayarların uygulanması için lütfen programı yeniden başlatın.");
        }

        #region Select Database Directory
        private void databaseDirectoryButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Access Dosyası Seçiniz...";
            openFileDialog.Filter = "Access Dosyası |*.accdb*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDirectory = openFileDialog.FileName;
                fileName = openFileDialog.SafeFileName;
            }

            databaseDirectoryTextBox.Text = fileDirectory;
        }
        #endregion

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            UpdateAppSettings();
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            DefaultAppSettings();
        }
    }
}
