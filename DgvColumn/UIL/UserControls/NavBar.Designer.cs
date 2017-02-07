namespace BudStudio.DgvColumn.UIL.UserControls
{
    partial class NavBar
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PnlBackGround = new System.Windows.Forms.Panel();
            this.PnlBottomLine = new System.Windows.Forms.Panel();
            this.PnlTopLine = new System.Windows.Forms.Panel();
            this.PnlBackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackgroundImage = global::BudStudio.DgvColumn.Properties.Resources.DesignerLogo;
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlLogo.Location = new System.Drawing.Point(0, 443);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(160, 50);
            this.PnlLogo.TabIndex = 0;
            // 
            // PnlBackGround
            // 
            this.PnlBackGround.BackgroundImage = global::BudStudio.DgvColumn.Properties.Resources.SideBarBG;
            this.PnlBackGround.Controls.Add(this.PnlBottomLine);
            this.PnlBackGround.Controls.Add(this.PnlTopLine);
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
            // PnlTopLine
            // 
            this.PnlTopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.PnlTopLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopLine.Location = new System.Drawing.Point(2, 0);
            this.PnlTopLine.Name = "PnlTopLine";
            this.PnlTopLine.Size = new System.Drawing.Size(153, 1);
            this.PnlTopLine.TabIndex = 0;
            // 
            // NavBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PnlBackGround);
            this.Controls.Add(this.PnlLogo);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(160, 493);
            this.SizeChanged += new System.EventHandler(this.NavBar_SizeChanged);
            this.PnlBackGround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Panel PnlBackGround;
        private System.Windows.Forms.Panel PnlTopLine;
        private System.Windows.Forms.Panel PnlBottomLine;
    }
}

