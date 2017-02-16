namespace ScheduleJobDesktop.UI.ManageScheduleJob
{
    partial class ScheduleJobList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlMainArea = new System.Windows.Forms.Panel();
            this.DgvGrid = new System.Windows.Forms.DataGridView();
            this.PnlTopTitle = new System.Windows.Forms.Panel();
            this.PicTitleLine = new System.Windows.Forms.PictureBox();
            this.PageBar = new ScheduleJobDesktop.UI.UserControls.PageBar();
            this.LblTip = new System.Windows.Forms.Label();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnCreate = new ScheduleJobDesktop.UserControls.Button();
            this.jobDataGridViewActionButtonColumn1 = new ScheduleJobDesktop.UI.UserControls.JobDataGridViewActionButtonColumn();
            this.dataGridViewActionButtonColumn1 = new ScheduleJobDesktop.UI.UserControls.JobDataGridViewActionButtonColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStateCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new ScheduleJobDesktop.UI.UserControls.JobDataGridViewActionButtonColumn();
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
            this.JobChineseName,
            this.ScheduleJobName,
            this.JobStatus,
            this.JobStateCode,
            this.StartTime,
            this.EndTime,
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
            this.PageBar.Location = new System.Drawing.Point(430, 57);
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
            this.PicTitle.Image = global::ScheduleJobDesktop.Properties.Resources.TitleManageScheduleJob_1;
            this.PicTitle.Location = new System.Drawing.Point(85, 0);
            this.PicTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(350, 43);
            this.PicTitle.TabIndex = 1;
            this.PicTitle.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::ScheduleJobDesktop.Properties.Resources.LogoScheduledTask;
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(20, 22, 10, 22);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(75, 81);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
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
            // jobDataGridViewActionButtonColumn1
            // 
            this.jobDataGridViewActionButtonColumn1.DataPropertyName = "JobId";
            this.jobDataGridViewActionButtonColumn1.HeaderText = "操作";
            this.jobDataGridViewActionButtonColumn1.Name = "jobDataGridViewActionButtonColumn1";
            this.jobDataGridViewActionButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jobDataGridViewActionButtonColumn1.Width = 120;
            // 
            // dataGridViewActionButtonColumn1
            // 
            this.dataGridViewActionButtonColumn1.DataPropertyName = "Id";
            this.dataGridViewActionButtonColumn1.HeaderText = "操作";
            this.dataGridViewActionButtonColumn1.Name = "dataGridViewActionButtonColumn1";
            this.dataGridViewActionButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActionButtonColumn1.Width = 120;
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            this.RowNum.HeaderText = "序号";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 80;
            // 
            // JobChineseName
            // 
            this.JobChineseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobChineseName.DataPropertyName = "JobChineseName";
            this.JobChineseName.HeaderText = "任务名称";
            this.JobChineseName.Name = "JobChineseName";
            this.JobChineseName.ReadOnly = true;
            // 
            // ScheduleJobName
            // 
            this.ScheduleJobName.DataPropertyName = "JobName";
            this.ScheduleJobName.HeaderText = "任务代号";
            this.ScheduleJobName.Name = "ScheduleJobName";
            this.ScheduleJobName.ReadOnly = true;
            this.ScheduleJobName.Width = 80;
            // 
            // JobStatus
            // 
            this.JobStatus.DataPropertyName = "StateDescription";
            this.JobStatus.HeaderText = "执行状态";
            this.JobStatus.Name = "JobStatus";
            this.JobStatus.ReadOnly = true;
            this.JobStatus.Width = 80;
            // 
            // JobStateCode
            // 
            this.JobStateCode.DataPropertyName = "State";
            this.JobStateCode.HeaderText = "执行状态代码";
            this.JobStateCode.Name = "JobStateCode";
            this.JobStateCode.ReadOnly = true;
            this.JobStateCode.Visible = false;
            this.JobStateCode.Width = 10;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartDate";
            this.StartTime.HeaderText = "开始时间";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndDate";
            this.EndTime.HeaderText = "结束时间";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            // 
            // ColAction
            // 
            this.ColAction.DataPropertyName = "JobId";
            this.ColAction.HeaderText = "操作";
            this.ColAction.Name = "ColAction";
            this.ColAction.ReadOnly = true;
            this.ColAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAction.Width = 240;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlMainArea);
            this.Name = "Default";
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
        private UserControls.JobDataGridViewActionButtonColumn jobDataGridViewActionButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStateCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private UserControls.JobDataGridViewActionButtonColumn ColAction;
    }
}
