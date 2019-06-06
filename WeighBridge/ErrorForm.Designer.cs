namespace Weighbridge
{
    partial class ErrorForm
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.errorTitle = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.errorIcon = new System.Windows.Forms.PictureBox();
            this.errorPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errorLabel.Location = new System.Drawing.Point(20, 13);
            this.errorLabel.MaximumSize = new System.Drawing.Size(415, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 19);
            this.errorLabel.TabIndex = 19;
            // 
            // errorPanel
            // 
            this.errorPanel.AutoSize = true;
            this.errorPanel.BackColor = System.Drawing.Color.White;
            this.errorPanel.Controls.Add(this.errorLabel);
            this.errorPanel.Location = new System.Drawing.Point(5, 31);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(455, 57);
            this.errorPanel.TabIndex = 20;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okButton.Location = new System.Drawing.Point(320, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(115, 30);
            this.okButton.TabIndex = 20;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // errorTitle
            // 
            this.errorTitle.AutoSize = true;
            this.errorTitle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errorTitle.ForeColor = System.Drawing.Color.White;
            this.errorTitle.Location = new System.Drawing.Point(29, 6);
            this.errorTitle.MaximumSize = new System.Drawing.Size(350, 0);
            this.errorTitle.Name = "errorTitle";
            this.errorTitle.Size = new System.Drawing.Size(43, 19);
            this.errorTitle.TabIndex = 21;
            this.errorTitle.Text = "Hata";
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.White;
            this.buttonPanel.Controls.Add(this.okButton);
            this.buttonPanel.Location = new System.Drawing.Point(5, 88);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(455, 36);
            this.buttonPanel.TabIndex = 21;
            // 
            // errorIcon
            // 
            this.errorIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorIcon.Image = global::Weighbridge.Properties.Resources.exclamation;
            this.errorIcon.Location = new System.Drawing.Point(5, 5);
            this.errorIcon.Name = "errorIcon";
            this.errorIcon.Size = new System.Drawing.Size(23, 23);
            this.errorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.errorIcon.TabIndex = 21;
            this.errorIcon.TabStop = false;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(466, 129);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.errorIcon);
            this.Controls.Add(this.errorTitle);
            this.Controls.Add(this.errorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ErrorForm_MouseDown);
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.PictureBox errorIcon;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label errorTitle;
        private System.Windows.Forms.Panel buttonPanel;
    }
}