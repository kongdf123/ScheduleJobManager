namespace ScheduleJobDesktop
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PnlContent = new System.Windows.Forms.Panel();
            this.NavBar = new ScheduleJobDesktop.UserControls.NavBar();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContent
            // 
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(160, 85);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(824, 577);
            this.PnlContent.TabIndex = 2;
            // 
            // NavBar
            // 
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.Location = new System.Drawing.Point(0, 85);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(160, 577);
            this.NavBar.TabIndex = 3;
            this.NavBar.QuitSystemClick += new System.EventHandler(this.NavBar_QuitSystemClick);
            this.NavBar.ImageButtonClick += new ScheduleJobDesktop.UserControls.NavBar.ButtonClickHander(this.NavBar_ImageButtonClick);
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackgroundImage = global::ScheduleJobDesktop.Properties.Resources.HeaderBG;
            this.PnlHeader.Controls.Add(this.PicLogo);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(984, 85);
            this.PnlHeader.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::ScheduleJobDesktop.Properties.Resources.Logo_0;
            this.PicLogo.Location = new System.Drawing.Point(0, 20);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(400, 45);
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.PnlHeader);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务调度系统 V1.0";
            this.PnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.PictureBox PicLogo;
        private UserControls.NavBar NavBar;
        private System.Windows.Forms.Panel PnlContent;
    }
}

