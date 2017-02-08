namespace ScheduleJobDesktop.UserControls
{
    partial class NavBar
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
            this.PnlBackGround = new System.Windows.Forms.Panel();
            this.PnlBottomLine = new System.Windows.Forms.Panel();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PnlBackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBackGround
            // 
            this.PnlBackGround.BackgroundImage = global::ScheduleJobDesktop.Properties.Resources.SideBarBG;
            this.PnlBackGround.Controls.Add(this.PnlBottomLine);
            this.PnlBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBackGround.Location = new System.Drawing.Point(0, 0);
            this.PnlBackGround.Name = "PnlBackGround";
            this.PnlBackGround.Padding = new System.Windows.Forms.Padding(2, 0, 5, 0);
            this.PnlBackGround.Size = new System.Drawing.Size(160, 443);
            this.PnlBackGround.TabIndex = 1;
            // 
            // PnlBottomLine
            // 
            this.PnlBottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.PnlBottomLine.Location = new System.Drawing.Point(2, 400);
            this.PnlBottomLine.Name = "PnlBottomLine";
            this.PnlBottomLine.Size = new System.Drawing.Size(153, 1);
            this.PnlBottomLine.TabIndex = 1;
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackgroundImage = global::ScheduleJobDesktop.Properties.Resources.DesignerLogo_1;
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlLogo.Location = new System.Drawing.Point(0, 443);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(160, 50);
            this.PnlLogo.TabIndex = 0;
            // 
            // NavBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PnlBackGround);
            this.Controls.Add(this.PnlLogo);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(160, 493);
            this.PnlBackGround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Panel PnlBackGround;
        private System.Windows.Forms.Panel PnlBottomLine;
    }
}
