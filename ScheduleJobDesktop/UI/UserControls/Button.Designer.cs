namespace JobMonitor.Desktop.UserControls
{
    partial class Button
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlBG = new System.Windows.Forms.Panel();
            this.LblText = new System.Windows.Forms.Label();
            this.PnlBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBG
            // 
            this.PnlBG.BackgroundImage = global::JobMonitor.Desktop.Properties.Resources.ButtonBG01;
            this.PnlBG.Controls.Add(this.LblText);
            this.PnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBG.Location = new System.Drawing.Point(1, 1);
            this.PnlBG.Name = "PnlBG";
            this.PnlBG.Size = new System.Drawing.Size(80, 24);
            this.PnlBG.TabIndex = 0;
            // 
            // LblText
            // 
            this.LblText.BackColor = System.Drawing.Color.Transparent;
            this.LblText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LblText.Location = new System.Drawing.Point(0, 0);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(80, 24);
            this.LblText.TabIndex = 0;
            this.LblText.Text = "按钮";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.Controls.Add(this.PnlBG);
            this.Name = "Button";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(82, 26);
            this.PnlBG.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PnlBG;
        private System.Windows.Forms.Label LblText;
    }
}
