namespace BudStudio.DgvColumn.UIL.ManageDepartment
{
    partial class Default
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTip = new System.Windows.Forms.Label();
            this.PageBar = new BudStudio.DgvColumn.UIL.UserControls.PageBar();
            this.PnlMainArea = new System.Windows.Forms.Panel();
            this.PnlDgvBack = new System.Windows.Forms.Panel();
            this.LblMemo01 = new System.Windows.Forms.Label();
            this.LinkBtnUrl = new System.Windows.Forms.LinkLabel();
            this.LblMemo = new System.Windows.Forms.Label();
            this.DgvGrid = new System.Windows.Forms.DataGridView();
            this.ColDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new BudStudio.DgvColumn.UIL.DataGridViewActionButtonColumn();
            this.PnlTopTitle = new System.Windows.Forms.Panel();
            this.PicTitleLine = new System.Windows.Forms.PictureBox();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnCreate = new BudStudio.DgvColumn.UIL.UserControls.Button();
            this.PnlMainArea.SuspendLayout();
            this.PnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrid)).BeginInit();
            this.PnlTopTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTip
            // 
            this.LblTip.Location = new System.Drawing.Point(85, 50);
            this.LblTip.Name = "LblTip";
            this.LblTip.Size = new System.Drawing.Size(350, 22);
            this.LblTip.TabIndex = 9;
            this.LblTip.Text = "提示：单击页面下方的“添加”按钮，添加新的部门信息。";
            this.LblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PageBar
            // 
            this.PageBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageBar.BackColor = System.Drawing.Color.White;
            this.PageBar.CurPage = 1;
            this.PageBar.DataControl = null;
            this.PageBar.DataSource = null;
            this.PageBar.Location = new System.Drawing.Point(438, 50);
            this.PageBar.MinimumSize = new System.Drawing.Size(350, 22);
            this.PageBar.Name = "PageBar";
            this.PageBar.PageSize = 15;
            this.PageBar.Size = new System.Drawing.Size(350, 22);
            this.PageBar.TabIndex = 8;
            this.PageBar.PageChanged += new System.EventHandler(this.PageBar_PageChanged);
            // 
            // PnlMainArea
            // 
            this.PnlMainArea.Controls.Add(this.PnlDgvBack);
            this.PnlMainArea.Controls.Add(this.PnlTopTitle);
            this.PnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PnlMainArea.Location = new System.Drawing.Point(0, 0);
            this.PnlMainArea.Name = "PnlMainArea";
            this.PnlMainArea.Padding = new System.Windows.Forms.Padding(20);
            this.PnlMainArea.Size = new System.Drawing.Size(830, 550);
            this.PnlMainArea.TabIndex = 4;
            // 
            // PnlDgvBack
            // 
            this.PnlDgvBack.Controls.Add(this.LblMemo01);
            this.PnlDgvBack.Controls.Add(this.LinkBtnUrl);
            this.PnlDgvBack.Controls.Add(this.LblMemo);
            this.PnlDgvBack.Controls.Add(this.DgvGrid);
            this.PnlDgvBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDgvBack.Location = new System.Drawing.Point(20, 100);
            this.PnlDgvBack.Name = "PnlDgvBack";
            this.PnlDgvBack.Size = new System.Drawing.Size(790, 430);
            this.PnlDgvBack.TabIndex = 7;
            // 
            // LblMemo01
            // 
            this.LblMemo01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblMemo01.AutoSize = true;
            this.LblMemo01.Location = new System.Drawing.Point(20, 404);
            this.LblMemo01.Name = "LblMemo01";
            this.LblMemo01.Size = new System.Drawing.Size(197, 12);
            this.LblMemo01.TabIndex = 28;
            this.LblMemo01.Text = "功能最强大的.Net平台代码生成器：";
            // 
            // LinkBtnUrl
            // 
            this.LinkBtnUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LinkBtnUrl.AutoSize = true;
            this.LinkBtnUrl.Location = new System.Drawing.Point(223, 404);
            this.LinkBtnUrl.Name = "LinkBtnUrl";
            this.LinkBtnUrl.Size = new System.Drawing.Size(161, 12);
            this.LinkBtnUrl.TabIndex = 27;
            this.LinkBtnUrl.TabStop = true;
            this.LinkBtnUrl.Text = "http://www.budeasycode.com";
            this.LinkBtnUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBtnUrl_LinkClicked);
            // 
            // LblMemo
            // 
            this.LblMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblMemo.AutoSize = true;
            this.LblMemo.BackColor = System.Drawing.Color.Transparent;
            this.LblMemo.ForeColor = System.Drawing.Color.Red;
            this.LblMemo.Location = new System.Drawing.Point(20, 380);
            this.LblMemo.Name = "LblMemo";
            this.LblMemo.Size = new System.Drawing.Size(221, 12);
            this.LblMemo.TabIndex = 26;
            this.LblMemo.Text = "本示例采用EasyCode代码生成器设计生成";
            // 
            // DgvGrid
            // 
            this.DgvGrid.AllowUserToAddRows = false;
            this.DgvGrid.AllowUserToDeleteRows = false;
            this.DgvGrid.AllowUserToOrderColumns = true;
            this.DgvGrid.AllowUserToResizeRows = false;
            this.DgvGrid.BackgroundColor = System.Drawing.Color.White;
            this.DgvGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGrid.ColumnHeadersHeight = 30;
            this.DgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDepartmentName,
            this.ColManagerName,
            this.ColContactPhone,
            this.ColAction});
            this.DgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGrid.GridColor = System.Drawing.Color.Silver;
            this.DgvGrid.Location = new System.Drawing.Point(0, 0);
            this.DgvGrid.MultiSelect = false;
            this.DgvGrid.Name = "DgvGrid";
            this.DgvGrid.ReadOnly = true;
            this.DgvGrid.RowHeadersVisible = false;
            this.DgvGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DgvGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DgvGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DgvGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGrid.RowTemplate.Height = 30;
            this.DgvGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGrid.Size = new System.Drawing.Size(790, 430);
            this.DgvGrid.TabIndex = 0;
            this.DgvGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvGrid_CellMouseClick);
            // 
            // ColDepartmentName
            // 
            this.ColDepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDepartmentName.DataPropertyName = "DepartmentName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDepartmentName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDepartmentName.HeaderText = "部门名称";
            this.ColDepartmentName.MinimumWidth = 60;
            this.ColDepartmentName.Name = "ColDepartmentName";
            this.ColDepartmentName.ReadOnly = true;
            this.ColDepartmentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColManagerName
            // 
            this.ColManagerName.DataPropertyName = "ManagerName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColManagerName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColManagerName.HeaderText = "经理姓名";
            this.ColManagerName.Name = "ColManagerName";
            this.ColManagerName.ReadOnly = true;
            this.ColManagerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColContactPhone
            // 
            this.ColContactPhone.DataPropertyName = "ContactPhone";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColContactPhone.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColContactPhone.HeaderText = "联系电话";
            this.ColContactPhone.Name = "ColContactPhone";
            this.ColContactPhone.ReadOnly = true;
            this.ColContactPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAction
            // 
            this.ColAction.DataPropertyName = "Id";
            this.ColAction.HeaderText = "操作";
            this.ColAction.Name = "ColAction";
            this.ColAction.ReadOnly = true;
            this.ColAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAction.Width = 120;
            // 
            // PnlTopTitle
            // 
            this.PnlTopTitle.Controls.Add(this.PicTitleLine);
            this.PnlTopTitle.Controls.Add(this.PicTitle);
            this.PnlTopTitle.Controls.Add(this.PicLogo);
            this.PnlTopTitle.Controls.Add(this.LblTip);
            this.PnlTopTitle.Controls.Add(this.PageBar);
            this.PnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopTitle.Location = new System.Drawing.Point(20, 20);
            this.PnlTopTitle.Name = "PnlTopTitle";
            this.PnlTopTitle.Size = new System.Drawing.Size(790, 80);
            this.PnlTopTitle.TabIndex = 6;
            // 
            // PicTitleLine
            // 
            this.PicTitleLine.Image = global::BudStudio.DgvColumn.Properties.Resources.TitleLine;
            this.PicTitleLine.Location = new System.Drawing.Point(85, 40);
            this.PicTitleLine.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitleLine.Name = "PicTitleLine";
            this.PicTitleLine.Size = new System.Drawing.Size(350, 5);
            this.PicTitleLine.TabIndex = 7;
            this.PicTitleLine.TabStop = false;
            // 
            // PicTitle
            // 
            this.PicTitle.Image = global::BudStudio.DgvColumn.Properties.Resources.TitleManageDepartmentList;
            this.PicTitle.Location = new System.Drawing.Point(85, 0);
            this.PicTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(350, 40);
            this.PicTitle.TabIndex = 6;
            this.PicTitle.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::BudStudio.DgvColumn.Properties.Resources.LogoManageDepartment;
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(75, 75);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 5;
            this.PicLogo.TabStop = false;
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackgroundImage = global::BudStudio.DgvColumn.Properties.Resources.FooterBG;
            this.PnlFooter.Controls.Add(this.BtnCreate);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 550);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(830, 50);
            this.PnlFooter.TabIndex = 3;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.BtnCreate.Location = new System.Drawing.Point(730, 12);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Padding = new System.Windows.Forms.Padding(1);
            this.BtnCreate.Size = new System.Drawing.Size(82, 26);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "添加";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlMainArea);
            this.Controls.Add(this.PnlFooter);
            this.Name = "Default";
            this.Size = new System.Drawing.Size(830, 600);
            this.PnlMainArea.ResumeLayout(false);
            this.PnlDgvBack.ResumeLayout(false);
            this.PnlDgvBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrid)).EndInit();
            this.PnlTopTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicTitleLine;
        private System.Windows.Forms.Panel PnlMainArea;
        private System.Windows.Forms.Panel PnlDgvBack;
        private System.Windows.Forms.Panel PnlTopTitle;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PnlFooter;
        private BudStudio.DgvColumn.UIL.UserControls.Button BtnCreate;
        private BudStudio.DgvColumn.UIL.UserControls.PageBar PageBar;
        private System.Windows.Forms.Label LblTip;
        private System.Windows.Forms.DataGridView DgvGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContactPhone;
        private DataGridViewActionButtonColumn ColAction;
        private System.Windows.Forms.Label LblMemo01;
        private System.Windows.Forms.LinkLabel LinkBtnUrl;
        private System.Windows.Forms.Label LblMemo;
    }
}
