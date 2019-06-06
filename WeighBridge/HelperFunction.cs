using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weighbridge
{
    public class HelperFunction
    {
        public void CreateMessageBox(String errorMessage)
        {
            ErrorForm errorDialog = new ErrorForm(errorMessage);
            errorDialog.ShowDialog();
        }

        public void CreateMessageBox(String errorType, String errorMessage)
        {
            ErrorForm errorDialog = new ErrorForm(errorType, errorMessage);
            errorDialog.ShowDialog();
        }

        //public void button_Enter(object sender, EventArgs e)
        //{
        //    ((Button)sender).BackColor = Color.LemonChiffon;
        //}

        //// Leave button event for changing button color to default when the mouse cursor is leaved from button
        //public void button_Leave(object sender, EventArgs e)
        //{
        //    ((Button)sender).BackColor = Color.LightBlue;
        //}

    }
}
