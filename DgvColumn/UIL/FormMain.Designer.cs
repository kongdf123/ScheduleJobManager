namespace BudStudio.DgvColumn.UIL
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PicCompanyLogo = new System.Windows.Forms.PictureBox();
            this.NavBar = new BudStudio.DgvColumn.UIL.UserControls.NavBar();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCompanyLogo)).BeginInit();
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
            // PnlHeader
            // 
            this.PnlHeader.BackgroundImage = global::BudStudio.DgvColumn.Properties.Resources.HeaderBG;
            this.PnlHeader.Controls.Add(this.PicLogo);
            this.PnlHeader.Controls.Add(this.PicCompanyLogo);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(984, 85);
            this.PnlHeader.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::BudStudio.DgvColumn.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(0, 20);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(400, 45);
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // PicCompanyLogo
            // 
            this.PicCompanyLogo.Image = global::BudStudio.DgvColumn.Properties.Resources.CompanyLogo;
            this.PicCompanyLogo.Location = new System.Drawing.Point(0, 0);
            this.PicCompanyLogo.Name = "PicCompanyLogo";
            this.PicCompanyLogo.Size = new System.Drawing.Size(200, 20);
            this.PicCompanyLogo.TabIndex = 0;
            this.PicCompanyLogo.TabStop = false;
            // 
            // NavBar
            // 
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.Location = new System.Drawing.Point(0, 85);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(160, 577);
            this.NavBar.TabIndex = 1;
            this.NavBar.QuitSystemClick += new System.EventHandler(this.NavBar_QuitSystemClick);
            this.NavBar.ImageButtonClick += new BudStudio.DgvColumn.UIL.UserControls.NavBar.ButtonClickHander(this.NavBar_ImageButtonClick);
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
            this.Text = "ＤataGridView按钮列示例";
            this.PnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.PictureBox PicCompanyLogo;
        private System.Windows.Forms.PictureBox PicLogo;
        private BudStudio.DgvColumn.UIL.UserControls.NavBar NavBar;
        private System.Windows.Forms.Panel PnlContent;
    }
}


