namespace ScheduleJobDesktop.UI.ManageSettings
{
    partial class SqlServerDBConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlMainArea = new System.Windows.Forms.Panel();
            this.DgvGrid = new System.Windows.Forms.DataGridView();
            this.PnlTopTitle = new System.Windows.Forms.Panel();
            this.PicTitleLine = new System.Windows.Forms.PictureBox();
            this.PageBar = new ScheduleJobDesktop.UI.UserControls.PageBar();
            this.LblTip = new System.Windows.Forms.Label();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewActionButtonColumn1 = new ScheduleJobDesktop.UI.UserControls.JobDataGridViewActionButtonColumn();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnCreate = new ScheduleJobDesktop.UserControls.Button();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new ScheduleJobDesktop.UI.UserControls.DBConfigDataGridViewActionButtonColumn();
            this.PnlMainArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrid)).BeginInit();
            this.PnlTopTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainArea
            // 
            this.PnlMainArea.AutoScroll = true;
            this.PnlMainArea.Controls.Add(this.DgvGrid);
            this.PnlMainArea.Controls.Add(this.PnlTopTitle);
            this.PnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PnlMainArea.Location = new System.Drawing.Point(0, 0);
            this.PnlMainArea.Name = "PnlMainArea";
            this.PnlMainArea.Padding = new System.Windows.Forms.Padding(20, 22, 20, 22);
            this.PnlMainArea.Size = new System.Drawing.Size(830, 650);
            this.PnlMainArea.TabIndex = 4;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGrid.ColumnHeadersHeight = 30;
            this.DgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ServerIPAddress,
            this.DBName,
            this.UserName,
            this.CreatedDate,
            this.UpdatedDate,
            this.ColAction});
            this.DgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGrid.GridColor = System.Drawing.Color.Silver;
            this.DgvGrid.Location = new System.Drawing.Point(20, 109);
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
            this.DgvGrid.Size = new System.Drawing.Size(790, 519);
            this.DgvGrid.TabIndex = 0;
            this.DgvGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvGrid_CellMouseClick);
            this.DgvGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvGrid_RowPostPaint);
            // 
            // PnlTopTitle
            // 
            this.PnlTopTitle.Controls.Add(this.PicTitleLine);
            this.PnlTopTitle.Controls.Add(this.PageBar);
            this.PnlTopTitle.Controls.Add(this.LblTip);
            this.PnlTopTitle.Controls.Add(this.PicTitle);
            this.PnlTopTitle.Controls.Add(this.PicLogo);
            this.PnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopTitle.Location = new System.Drawing.Point(20, 22);
            this.PnlTopTitle.Name = "PnlTopTitle";
            this.PnlTopTitle.Size = new System.Drawing.Size(790, 87);
            this.PnlTopTitle.TabIndex = 0;
            // 
            // PicTitleLine
            // 
            this.PicTitleLine.Image = global::ScheduleJobDesktop.Properties.Resources.TitleLine;
            this.PicTitleLine.Location = new System.Drawing.Point(85, 43);
            this.PicTitleLine.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitleLine.Name = "PicTitleLine";
            this.PicTitleLine.Size = new System.Drawing.Size(350, 5);
            this.PicTitleLine.TabIndex = 4;
            this.PicTitleLine.TabStop = false;
            // 
            // PageBar
            // 
            this.PageBar.BackColor = System.Drawing.Color.White;
            this.PageBar.CurPage = 1;
            this.PageBar.DataControl = null;
            this.PageBar.DataSource = null;
            this.PageBar.Location = new System.Drawing.Point(419, 57);
            this.PageBar.MinimumSize = new System.Drawing.Size(350, 24);
            this.PageBar.Name = "PageBar";
            this.PageBar.PageSize = 15;
            this.PageBar.Size = new System.Drawing.Size(350, 24);
            this.PageBar.TabIndex = 8;
            this.PageBar.PageChanged += new System.EventHandler(this.PageBar_PageChanged);
            // 
            // LblTip
            // 
            this.LblTip.AutoSize = true;
            this.LblTip.Location = new System.Drawing.Point(89, 62);
            this.LblTip.Name = "LblTip";
            this.LblTip.Size = new System.Drawing.Size(277, 13);
            this.LblTip.TabIndex = 9;
            this.LblTip.Text = "提示：单击页面下方的“添加”按钮，添加相应的信息。";
            this.LblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicTitle
            // 
            this.PicTitle.Image = global::ScheduleJobDesktop.Properties.Resources.TitleManageDBConfig;
            this.PicTitle.Location = new System.Drawing.Point(85, 0);
            this.PicTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(350, 43);
            this.PicTitle.TabIndex = 1;
            this.PicTitle.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::ScheduleJobDesktop.Properties.Resources.NavBtnManageDBConfig;
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(20, 22, 10, 22);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(75, 81);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // dataGridViewActionButtonColumn1
            // 
            this.dataGridViewActionButtonColumn1.DataPropertyName = "Id";
            this.dataGridViewActionButtonColumn1.HeaderText = "操作";
            this.dataGridViewActionButtonColumn1.Name = "dataGridViewActionButtonColumn1";
            this.dataGridViewActionButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActionButtonColumn1.Width = 120;
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackgroundImage = global::ScheduleJobDesktop.Properties.Resources.FooterBG;
            this.PnlFooter.Controls.Add(this.BtnCreate);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 602);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(830, 48);
            this.PnlFooter.TabIndex = 1;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.BtnCreate.Location = new System.Drawing.Point(730, 7);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Padding = new System.Windows.Forms.Padding(1);
            this.BtnCreate.Size = new System.Drawing.Size(82, 26);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "添加";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            this.RowNum.HeaderText = "序号";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 80;
            // 
            // ServerIPAddress
            // 
            this.ServerIPAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServerIPAddress.DataPropertyName = "ServerAddress";
            this.ServerIPAddress.HeaderText = "服务器地址";
            this.ServerIPAddress.Name = "ServerIPAddress";
            this.ServerIPAddress.ReadOnly = true;
            // 
            // DBName
            // 
            this.DBName.DataPropertyName = "DBName";
            this.DBName.HeaderText = "数据库名称";
            this.DBName.Name = "DBName";
            this.DBName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "创建时间";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // UpdatedDate
            // 
            this.UpdatedDate.DataPropertyName = "UpdatedDate";
            this.UpdatedDate.HeaderText = "更新时间";
            this.UpdatedDate.Name = "UpdatedDate";
            this.UpdatedDate.ReadOnly = true;
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
            // DBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlMainArea);
            this.Name = "DBConfig";
            this.Size = new System.Drawing.Size(830, 650);
            this.PnlMainArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrid)).EndInit();
            this.PnlTopTitle.ResumeLayout(false);
            this.PnlTopTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainArea;
        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Panel PnlTopTitle;
        private System.Windows.Forms.DataGridView DgvGrid;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label LblTip;
        private ScheduleJobDesktop.UserControls.Button BtnCreate;
        private UserControls.PageBar PageBar;
        private System.Windows.Forms.PictureBox PicTitleLine;
        private UserControls.JobDataGridViewActionButtonColumn dataGridViewActionButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedDate;
        private UserControls.DBConfigDataGridViewActionButtonColumn ColAction;
    }
}
