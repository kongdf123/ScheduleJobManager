namespace BudStudio.DgvColumn.UIL.ManageDepartment
{
    partial class Delete
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
            this.PnlScrollArea = new System.Windows.Forms.Panel();
            this.SpaceBottom = new System.Windows.Forms.Panel();
            this.PnlInfo = new System.Windows.Forms.Panel();
            this.PnlInfoBack = new System.Windows.Forms.Panel();
            this.PnlControlArea = new System.Windows.Forms.Panel();
            this.LblModuleMemo = new System.Windows.Forms.Label();
            this.PnlInfoTopLine = new System.Windows.Forms.Panel();
            this.PicTitleLine = new System.Windows.Forms.PictureBox();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlInfoTitle = new System.Windows.Forms.Panel();
            this.LblModuleTitle = new System.Windows.Forms.Label();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnDelete = new BudStudio.DgvColumn.UIL.UserControls.Button();
            this.BtnCancel = new BudStudio.DgvColumn.UIL.UserControls.Button();
            this.PnlScrollArea.SuspendLayout();
            this.PnlInfo.SuspendLayout();
            this.PnlInfoBack.SuspendLayout();
            this.PnlControlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlInfoTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlScrollArea
            // 
            this.PnlScrollArea.AutoScroll = true;
            this.PnlScrollArea.Controls.Add(this.SpaceBottom);
            this.PnlScrollArea.Controls.Add(this.PnlInfo);
            this.PnlScrollArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlScrollArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PnlScrollArea.Location = new System.Drawing.Point(0, 0);
            this.PnlScrollArea.Name = "PnlScrollArea";
            this.PnlScrollArea.Padding = new System.Windows.Forms.Padding(20);
            this.PnlScrollArea.Size = new System.Drawing.Size(830, 550);
            this.PnlScrollArea.TabIndex = 4;
            // 
            // SpaceBottom
            // 
            this.SpaceBottom.BackColor = System.Drawing.Color.White;
            this.SpaceBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpaceBottom.Location = new System.Drawing.Point(20, 320);
            this.SpaceBottom.Name = "SpaceBottom";
            this.SpaceBottom.Size = new System.Drawing.Size(790, 20);
            this.SpaceBottom.TabIndex = 6;
            // 
            // PnlInfo
            // 
            this.PnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PnlInfo.Controls.Add(this.PnlInfoBack);
            this.PnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlInfo.Location = new System.Drawing.Point(20, 20);
            this.PnlInfo.Name = "PnlInfo";
            this.PnlInfo.Padding = new System.Windows.Forms.Padding(1);
            this.PnlInfo.Size = new System.Drawing.Size(790, 300);
            this.PnlInfo.TabIndex = 0;
            // 
            // PnlInfoBack
            // 
            this.PnlInfoBack.BackColor = System.Drawing.Color.White;
            this.PnlInfoBack.Controls.Add(this.PnlControlArea);
            this.PnlInfoBack.Controls.Add(this.PnlInfoTopLine);
            this.PnlInfoBack.Controls.Add(this.PnlInfoTitle);
            this.PnlInfoBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlInfoBack.Location = new System.Drawing.Point(1, 1);
            this.PnlInfoBack.Name = "PnlInfoBack";
            this.PnlInfoBack.Size = new System.Drawing.Size(788, 298);
            this.PnlInfoBack.TabIndex = 2;
            // 
            // PnlControlArea
            // 
            this.PnlControlArea.BackColor = System.Drawing.Color.White;
            this.PnlControlArea.Controls.Add(this.BtnDelete);
            this.PnlControlArea.Controls.Add(this.BtnCancel);
            this.PnlControlArea.Controls.Add(this.LblModuleMemo);
            this.PnlControlArea.Controls.Add(this.PicTitleLine);
            this.PnlControlArea.Controls.Add(this.PicTitle);
            this.PnlControlArea.Controls.Add(this.PicLogo);
            this.PnlControlArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlControlArea.Location = new System.Drawing.Point(0, 26);
            this.PnlControlArea.Name = "PnlControlArea";
            this.PnlControlArea.Padding = new System.Windows.Forms.Padding(20);
            this.PnlControlArea.Size = new System.Drawing.Size(788, 272);
            this.PnlControlArea.TabIndex = 4;
            // 
            // LblModuleMemo
            // 
            this.LblModuleMemo.Location = new System.Drawing.Point(140, 110);
            this.LblModuleMemo.Margin = new System.Windows.Forms.Padding(0);
            this.LblModuleMemo.Name = "LblModuleMemo";
            this.LblModuleMemo.Size = new System.Drawing.Size(615, 40);
            this.LblModuleMemo.TabIndex = 3;
            this.LblModuleMemo.Text = "“部门信息”删除之后不可以恢复，真的要删除该信息吗？";
            this.LblModuleMemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlInfoTopLine
            // 
            this.PnlInfoTopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PnlInfoTopLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlInfoTopLine.Location = new System.Drawing.Point(0, 25);
            this.PnlInfoTopLine.Name = "PnlInfoTopLine";
            this.PnlInfoTopLine.Size = new System.Drawing.Size(788, 1);
            this.PnlInfoTopLine.TabIndex = 3;
            // 
            // PicTitleLine
            // 
            this.PicTitleLine.Image = global::BudStudio.DgvColumn.Properties.Resources.TitleLine;
            this.PicTitleLine.Location = new System.Drawing.Point(140, 60);
            this.PicTitleLine.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitleLine.Name = "PicTitleLine";
            this.PicTitleLine.Size = new System.Drawing.Size(350, 20);
            this.PicTitleLine.TabIndex = 2;
            this.PicTitleLine.TabStop = false;
            // 
            // PicTitle
            // 
            this.PicTitle.Image = global::BudStudio.DgvColumn.Properties.Resources.TitleManageDepartmentDelete;
            this.PicTitle.Location = new System.Drawing.Point(140, 20);
            this.PicTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(350, 40);
            this.PicTitle.TabIndex = 1;
            this.PicTitle.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::BudStudio.DgvColumn.Properties.Resources.Delete;
            this.PicLogo.Location = new System.Drawing.Point(20, 20);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(20);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(100, 100);
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // PnlInfoTitle
            // 
            this.PnlInfoTitle.BackColor = System.Drawing.Color.White;
            this.PnlInfoTitle.BackgroundImage = global::BudStudio.DgvColumn.Properties.Resources.TableHeaderBG;
            this.PnlInfoTitle.Controls.Add(this.LblModuleTitle);
            this.PnlInfoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlInfoTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlInfoTitle.Name = "PnlInfoTitle";
            this.PnlInfoTitle.Size = new System.Drawing.Size(788, 25);
            this.PnlInfoTitle.TabIndex = 2;
            // 
            // LblModuleTitle
            // 
            this.LblModuleTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblModuleTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblModuleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.LblModuleTitle.Location = new System.Drawing.Point(5, 1);
            this.LblModuleTitle.Name = "LblModuleTitle";
            this.LblModuleTitle.Size = new System.Drawing.Size(300, 23);
            this.LblModuleTitle.TabIndex = 1;
            this.LblModuleTitle.Text = "部门管理";
            this.LblModuleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackgroundImage = global::BudStudio.DgvColumn.Properties.Resources.FooterBG;
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 550);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(830, 50);
            this.PnlFooter.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.BtnDelete.Location = new System.Drawing.Point(595, 223);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(1);
            this.BtnDelete.Size = new System.Drawing.Size(82, 26);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.BtnCancel.Location = new System.Drawing.Point(683, 223);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(1);
            this.BtnCancel.Size = new System.Drawing.Size(82, 26);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlScrollArea);
            this.Controls.Add(this.PnlFooter);
            this.Name = "Delete";
            this.Size = new System.Drawing.Size(830, 600);
            this.PnlScrollArea.ResumeLayout(false);
            this.PnlInfo.ResumeLayout(false);
            this.PnlInfoBack.ResumeLayout(false);
            this.PnlControlArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlInfoTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlScrollArea;
        private System.Windows.Forms.Panel SpaceBottom;
        private System.Windows.Forms.Panel PnlInfo;
        private System.Windows.Forms.Panel PnlInfoBack;
        private System.Windows.Forms.Panel PnlControlArea;
        private System.Windows.Forms.Label LblModuleMemo;
        private System.Windows.Forms.PictureBox PicTitleLine;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PnlInfoTopLine;
        private System.Windows.Forms.Panel PnlInfoTitle;
        private System.Windows.Forms.Label LblModuleTitle;
        private System.Windows.Forms.Panel PnlFooter;
        private BudStudio.DgvColumn.UIL.UserControls.Button BtnDelete;
        private BudStudio.DgvColumn.UIL.UserControls.Button BtnCancel;
    }
}

