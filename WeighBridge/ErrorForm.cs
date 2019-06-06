using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Weighbridge
{
    public partial class ErrorForm : Form
    {
        #region Make Borderless Form Movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void ErrorForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        #endregion
        public ErrorForm()
        {
            InitializeComponent();
        }
        public ErrorForm(String errorMessage)
        {
            InitializeComponent();
            errorLabel.Text = errorMessage;
        }
        public ErrorForm(String errorType, String errorMessage)
        {
            InitializeComponent();
            if (errorType == "Uyarı")
            {
                this.BackColor = ColorTranslator.FromHtml("#90caf9");
                errorIcon.BackColor = ColorTranslator.FromHtml("#90caf9");
                errorLabel.Text = errorMessage;
                errorTitle.Text = errorType;
                errorIcon.Image = Properties.Resources.check;
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            buttonPanel.Location = new Point(errorPanel.Location.X, errorPanel.Location.Y + errorPanel.Size.Height);
        }
    }
}
