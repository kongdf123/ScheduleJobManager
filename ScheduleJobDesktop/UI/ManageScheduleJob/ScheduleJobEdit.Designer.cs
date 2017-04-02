using ScheduleJobDesktop.Properties;

namespace ScheduleJobDesktop.UI.ManageScheduleJob
{
    partial class ScheduleJobEdit
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
			this.PnlJobState = new System.Windows.Forms.Panel();
			this.RadioBtnWaiting = new System.Windows.Forms.RadioButton();
			this.RadioBtnRunning = new System.Windows.Forms.RadioButton();
			this.RadioBtnStopping = new System.Windows.Forms.RadioButton();
			this.PnlInterval = new System.Windows.Forms.Panel();
			this.RadioBtnDay = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.TxtDay = new ScheduleJobDesktop.UI.UserControls.TextBox();
			this.TxtMinute = new ScheduleJobDesktop.UI.UserControls.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.RadioBtnMinute = new System.Windows.Forms.RadioButton();
			this.RadioBtnHour = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.TxtHour = new ScheduleJobDesktop.UI.UserControls.TextBox();
			this.TxtScheduleChineseName = new ScheduleJobDesktop.UI.UserControls.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.DateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.DateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.ComBoxFreq = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TxtJobIdentity = new ScheduleJobDesktop.UI.UserControls.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtNoteDescription = new ScheduleJobDesktop.UI.UserControls.TextBox();
			this.PicNotNullScheduleServiceURL = new System.Windows.Forms.PictureBox();
			this.Lbl_ScheduleName = new System.Windows.Forms.Label();
			this.PicNotNullScheduleName = new System.Windows.Forms.PictureBox();
			this.Lbl_ManagerName = new System.Windows.Forms.Label();
			this.TxtServiceAddress = new ScheduleJobDesktop.UI.UserControls.TextBox();
			this.Lbl_ContactPhone = new System.Windows.Forms.Label();
			this.Lbl_NoteDescription = new System.Windows.Forms.Label();
			this.PicTitleLine = new System.Windows.Forms.PictureBox();
			this.PicTitle = new System.Windows.Forms.PictureBox();
			this.PicLogo = new System.Windows.Forms.PictureBox();
			this.PnlInfoTopLine = new System.Windows.Forms.Panel();
			this.PnlInfoTitle = new System.Windows.Forms.Panel();
			this.LblModuleTitle = new System.Windows.Forms.Label();
			this.PnlFooter = new System.Windows.Forms.Panel();
			this.BtnSave = new ScheduleJobDesktop.UserControls.Button();
			this.BtnCancel = new ScheduleJobDesktop.UserControls.Button();
			this.PnlScrollArea.SuspendLayout();
			this.PnlInfo.SuspendLayout();
			this.PnlInfoBack.SuspendLayout();
			this.PnlControlArea.SuspendLayout();
			this.PnlJobState.SuspendLayout();
			this.PnlInterval.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicNotNullScheduleServiceURL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicNotNullScheduleName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
			this.PnlInfoTitle.SuspendLayout();
			this.PnlFooter.SuspendLayout();
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
			this.PnlScrollArea.Padding = new System.Windows.Forms.Padding(20, 22, 20, 22);
			this.PnlScrollArea.Size = new System.Drawing.Size(830, 596);
			this.PnlScrollArea.TabIndex = 4;
			// 
			// SpaceBottom
			// 
			this.SpaceBottom.BackColor = System.Drawing.Color.White;
			this.SpaceBottom.Dock = System.Windows.Forms.DockStyle.Top;
			this.SpaceBottom.Location = new System.Drawing.Point(20, 582);
			this.SpaceBottom.Name = "SpaceBottom";
			this.SpaceBottom.Size = new System.Drawing.Size(773, 22);
			this.SpaceBottom.TabIndex = 6;
			// 
			// PnlInfo
			// 
			this.PnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.PnlInfo.Controls.Add(this.PnlInfoBack);
			this.PnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlInfo.Location = new System.Drawing.Point(20, 22);
			this.PnlInfo.Name = "PnlInfo";
			this.PnlInfo.Padding = new System.Windows.Forms.Padding(1);
			this.PnlInfo.Size = new System.Drawing.Size(773, 560);
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
			this.PnlInfoBack.Size = new System.Drawing.Size(771, 558);
			this.PnlInfoBack.TabIndex = 2;
			// 
			// PnlControlArea
			// 
			this.PnlControlArea.BackColor = System.Drawing.Color.White;
			this.PnlControlArea.Controls.Add(this.PnlJobState);
			this.PnlControlArea.Controls.Add(this.PnlInterval);
			this.PnlControlArea.Controls.Add(this.TxtScheduleChineseName);
			this.PnlControlArea.Controls.Add(this.label6);
			this.PnlControlArea.Controls.Add(this.DateTimePickerEnd);
			this.PnlControlArea.Controls.Add(this.label4);
			this.PnlControlArea.Controls.Add(this.DateTimePickerStart);
			this.PnlControlArea.Controls.Add(this.label3);
			this.PnlControlArea.Controls.Add(this.ComBoxFreq);
			this.PnlControlArea.Controls.Add(this.pictureBox1);
			this.PnlControlArea.Controls.Add(this.TxtJobIdentity);
			this.PnlControlArea.Controls.Add(this.label2);
			this.PnlControlArea.Controls.Add(this.label1);
			this.PnlControlArea.Controls.Add(this.TxtNoteDescription);
			this.PnlControlArea.Controls.Add(this.PicNotNullScheduleServiceURL);
			this.PnlControlArea.Controls.Add(this.Lbl_ScheduleName);
			this.PnlControlArea.Controls.Add(this.PicNotNullScheduleName);
			this.PnlControlArea.Controls.Add(this.Lbl_ManagerName);
			this.PnlControlArea.Controls.Add(this.TxtServiceAddress);
			this.PnlControlArea.Controls.Add(this.Lbl_ContactPhone);
			this.PnlControlArea.Controls.Add(this.Lbl_NoteDescription);
			this.PnlControlArea.Controls.Add(this.PicTitleLine);
			this.PnlControlArea.Controls.Add(this.PicTitle);
			this.PnlControlArea.Controls.Add(this.PicLogo);
			this.PnlControlArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlControlArea.Location = new System.Drawing.Point(0, 28);
			this.PnlControlArea.Name = "PnlControlArea";
			this.PnlControlArea.Padding = new System.Windows.Forms.Padding(20, 22, 20, 22);
			this.PnlControlArea.Size = new System.Drawing.Size(771, 530);
			this.PnlControlArea.TabIndex = 4;
			// 
			// PnlJobState
			// 
			this.PnlJobState.Controls.Add(this.RadioBtnWaiting);
			this.PnlJobState.Controls.Add(this.RadioBtnRunning);
			this.PnlJobState.Controls.Add(this.RadioBtnStopping);
			this.PnlJobState.Location = new System.Drawing.Point(230, 207);
			this.PnlJobState.Name = "PnlJobState";
			this.PnlJobState.Size = new System.Drawing.Size(219, 25);
			this.PnlJobState.TabIndex = 36;
			// 
			// RadioBtnWaiting
			// 
			this.RadioBtnWaiting.AutoSize = true;
			this.RadioBtnWaiting.Location = new System.Drawing.Point(3, 5);
			this.RadioBtnWaiting.Name = "RadioBtnWaiting";
			this.RadioBtnWaiting.Size = new System.Drawing.Size(49, 17);
			this.RadioBtnWaiting.TabIndex = 24;
			this.RadioBtnWaiting.TabStop = true;
			this.RadioBtnWaiting.Text = "等待";
			this.RadioBtnWaiting.UseVisualStyleBackColor = true;
			// 
			// RadioBtnRunning
			// 
			this.RadioBtnRunning.AutoSize = true;
			this.RadioBtnRunning.Location = new System.Drawing.Point(79, 5);
			this.RadioBtnRunning.Name = "RadioBtnRunning";
			this.RadioBtnRunning.Size = new System.Drawing.Size(49, 17);
			this.RadioBtnRunning.TabIndex = 23;
			this.RadioBtnRunning.TabStop = true;
			this.RadioBtnRunning.Text = "运行";
			this.RadioBtnRunning.UseVisualStyleBackColor = true;
			// 
			// RadioBtnStopping
			// 
			this.RadioBtnStopping.AutoSize = true;
			this.RadioBtnStopping.Location = new System.Drawing.Point(152, 5);
			this.RadioBtnStopping.Name = "RadioBtnStopping";
			this.RadioBtnStopping.Size = new System.Drawing.Size(49, 17);
			this.RadioBtnStopping.TabIndex = 25;
			this.RadioBtnStopping.TabStop = true;
			this.RadioBtnStopping.Text = "停止";
			this.RadioBtnStopping.UseVisualStyleBackColor = true;
			// 
			// PnlInterval
			// 
			this.PnlInterval.Controls.Add(this.RadioBtnDay);
			this.PnlInterval.Controls.Add(this.label9);
			this.PnlInterval.Controls.Add(this.TxtDay);
			this.PnlInterval.Controls.Add(this.TxtMinute);
			this.PnlInterval.Controls.Add(this.label8);
			this.PnlInterval.Controls.Add(this.RadioBtnMinute);
			this.PnlInterval.Controls.Add(this.RadioBtnHour);
			this.PnlInterval.Controls.Add(this.label7);
			this.PnlInterval.Controls.Add(this.TxtHour);
			this.PnlInterval.Location = new System.Drawing.Point(229, 311);
			this.PnlInterval.Name = "PnlInterval";
			this.PnlInterval.Size = new System.Drawing.Size(200, 93);
			this.PnlInterval.TabIndex = 35;
			// 
			// RadioBtnDay
			// 
			this.RadioBtnDay.AutoSize = true;
			this.RadioBtnDay.Location = new System.Drawing.Point(3, 8);
			this.RadioBtnDay.Name = "RadioBtnDay";
			this.RadioBtnDay.Size = new System.Drawing.Size(37, 17);
			this.RadioBtnDay.TabIndex = 26;
			this.RadioBtnDay.TabStop = true;
			this.RadioBtnDay.Text = "每";
			this.RadioBtnDay.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(89, 58);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 21);
			this.label9.TabIndex = 34;
			this.label9.Text = "分";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtDay
			// 
			this.TxtDay.BackColor = System.Drawing.Color.White;
			this.TxtDay.BoxBackColor = System.Drawing.Color.White;
			this.TxtDay.Location = new System.Drawing.Point(41, 3);
			this.TxtDay.MaxLength = 2;
			this.TxtDay.Multiline = false;
			this.TxtDay.Name = "TxtDay";
			this.TxtDay.Padding = new System.Windows.Forms.Padding(1);
			this.TxtDay.PasswordChar = '\0';
			this.TxtDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtDay.Size = new System.Drawing.Size(37, 27);
			this.TxtDay.TabIndex = 27;
			// 
			// TxtMinute
			// 
			this.TxtMinute.BackColor = System.Drawing.Color.White;
			this.TxtMinute.BoxBackColor = System.Drawing.Color.White;
			this.TxtMinute.Location = new System.Drawing.Point(41, 58);
			this.TxtMinute.MaxLength = 2;
			this.TxtMinute.Multiline = false;
			this.TxtMinute.Name = "TxtMinute";
			this.TxtMinute.Padding = new System.Windows.Forms.Padding(1);
			this.TxtMinute.PasswordChar = '\0';
			this.TxtMinute.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtMinute.Size = new System.Drawing.Size(37, 27);
			this.TxtMinute.TabIndex = 33;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(89, 5);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 22);
			this.label8.TabIndex = 31;
			this.label8.Text = "天";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RadioBtnMinute
			// 
			this.RadioBtnMinute.AutoSize = true;
			this.RadioBtnMinute.Location = new System.Drawing.Point(2, 58);
			this.RadioBtnMinute.Name = "RadioBtnMinute";
			this.RadioBtnMinute.Size = new System.Drawing.Size(37, 17);
			this.RadioBtnMinute.TabIndex = 32;
			this.RadioBtnMinute.TabStop = true;
			this.RadioBtnMinute.Text = "每";
			this.RadioBtnMinute.UseVisualStyleBackColor = true;
			// 
			// RadioBtnHour
			// 
			this.RadioBtnHour.AutoSize = true;
			this.RadioBtnHour.Location = new System.Drawing.Point(2, 33);
			this.RadioBtnHour.Name = "RadioBtnHour";
			this.RadioBtnHour.Size = new System.Drawing.Size(37, 17);
			this.RadioBtnHour.TabIndex = 29;
			this.RadioBtnHour.TabStop = true;
			this.RadioBtnHour.Text = "每";
			this.RadioBtnHour.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(89, 30);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "小时";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtHour
			// 
			this.TxtHour.BackColor = System.Drawing.Color.White;
			this.TxtHour.BoxBackColor = System.Drawing.Color.White;
			this.TxtHour.Location = new System.Drawing.Point(41, 30);
			this.TxtHour.MaxLength = 2;
			this.TxtHour.Multiline = false;
			this.TxtHour.Name = "TxtHour";
			this.TxtHour.Padding = new System.Windows.Forms.Padding(1);
			this.TxtHour.PasswordChar = '\0';
			this.TxtHour.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtHour.Size = new System.Drawing.Size(37, 27);
			this.TxtHour.TabIndex = 30;
			// 
			// TxtScheduleChineseName
			// 
			this.TxtScheduleChineseName.BackColor = System.Drawing.Color.White;
			this.TxtScheduleChineseName.BoxBackColor = System.Drawing.Color.White;
			this.TxtScheduleChineseName.Location = new System.Drawing.Point(230, 93);
			this.TxtScheduleChineseName.MaxLength = 50;
			this.TxtScheduleChineseName.Multiline = false;
			this.TxtScheduleChineseName.Name = "TxtScheduleChineseName";
			this.TxtScheduleChineseName.Padding = new System.Windows.Forms.Padding(1);
			this.TxtScheduleChineseName.PasswordChar = '\0';
			this.TxtScheduleChineseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtScheduleChineseName.Size = new System.Drawing.Size(199, 27);
			this.TxtScheduleChineseName.TabIndex = 22;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(140, 328);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 43);
			this.label6.TabIndex = 18;
			this.label6.Text = "执行间隔：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DateTimePickerEnd
			// 
			this.DateTimePickerEnd.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
			this.DateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePickerEnd.Location = new System.Drawing.Point(475, 279);
			this.DateTimePickerEnd.Name = "DateTimePickerEnd";
			this.DateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
			this.DateTimePickerEnd.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(445, 270);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 32);
			this.label4.TabIndex = 14;
			this.label4.Text = "至";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DateTimePickerStart
			// 
			this.DateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.DateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.DateTimePickerStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.DateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePickerStart.Location = new System.Drawing.Point(231, 279);
			this.DateTimePickerStart.Name = "DateTimePickerStart";
			this.DateTimePickerStart.Size = new System.Drawing.Size(200, 20);
			this.DateTimePickerStart.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(140, 270);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 43);
			this.label3.TabIndex = 12;
			this.label3.Text = "计划日期：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ComBoxFreq
			// 
			this.ComBoxFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComBoxFreq.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.ComBoxFreq.FormattingEnabled = true;
			this.ComBoxFreq.ItemHeight = 17;
			this.ComBoxFreq.Location = new System.Drawing.Point(230, 242);
			this.ComBoxFreq.Name = "ComBoxFreq";
			this.ComBoxFreq.Size = new System.Drawing.Size(121, 25);
			this.ComBoxFreq.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ScheduleJobDesktop.Properties.Resources.NotNull;
			this.pictureBox1.Location = new System.Drawing.Point(435, 133);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(14, 22);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// TxtJobIdentity
			// 
			this.TxtJobIdentity.BackColor = System.Drawing.Color.White;
			this.TxtJobIdentity.BoxBackColor = System.Drawing.Color.White;
			this.TxtJobIdentity.Location = new System.Drawing.Point(230, 133);
			this.TxtJobIdentity.MaxLength = 20;
			this.TxtJobIdentity.Multiline = false;
			this.TxtJobIdentity.Name = "TxtJobIdentity";
			this.TxtJobIdentity.Padding = new System.Windows.Forms.Padding(1);
			this.TxtJobIdentity.PasswordChar = '\0';
			this.TxtJobIdentity.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtJobIdentity.Size = new System.Drawing.Size(199, 27);
			this.TxtJobIdentity.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(140, 123);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 43);
			this.label2.TabIndex = 7;
			this.label2.Text = "任务代号：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(140, 231);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 43);
			this.label1.TabIndex = 6;
			this.label1.Text = "执行频率：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtNoteDescription
			// 
			this.TxtNoteDescription.BackColor = System.Drawing.Color.White;
			this.TxtNoteDescription.BoxBackColor = System.Drawing.Color.White;
			this.TxtNoteDescription.Location = new System.Drawing.Point(230, 424);
			this.TxtNoteDescription.MaxLength = 200;
			this.TxtNoteDescription.Multiline = true;
			this.TxtNoteDescription.Name = "TxtNoteDescription";
			this.TxtNoteDescription.Padding = new System.Windows.Forms.Padding(1);
			this.TxtNoteDescription.PasswordChar = '\0';
			this.TxtNoteDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxtNoteDescription.Size = new System.Drawing.Size(400, 66);
			this.TxtNoteDescription.TabIndex = 0;
			// 
			// PicNotNullScheduleServiceURL
			// 
			this.PicNotNullScheduleServiceURL.Image = global::ScheduleJobDesktop.Properties.Resources.NotNull;
			this.PicNotNullScheduleServiceURL.Location = new System.Drawing.Point(588, 170);
			this.PicNotNullScheduleServiceURL.Name = "PicNotNullScheduleServiceURL";
			this.PicNotNullScheduleServiceURL.Size = new System.Drawing.Size(14, 22);
			this.PicNotNullScheduleServiceURL.TabIndex = 4;
			this.PicNotNullScheduleServiceURL.TabStop = false;
			// 
			// Lbl_ScheduleName
			// 
			this.Lbl_ScheduleName.Location = new System.Drawing.Point(140, 87);
			this.Lbl_ScheduleName.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_ScheduleName.Name = "Lbl_ScheduleName";
			this.Lbl_ScheduleName.Size = new System.Drawing.Size(90, 43);
			this.Lbl_ScheduleName.TabIndex = 3;
			this.Lbl_ScheduleName.Text = "任务名称：";
			this.Lbl_ScheduleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PicNotNullScheduleName
			// 
			this.PicNotNullScheduleName.Image = global::ScheduleJobDesktop.Properties.Resources.NotNull;
			this.PicNotNullScheduleName.Location = new System.Drawing.Point(435, 97);
			this.PicNotNullScheduleName.Name = "PicNotNullScheduleName";
			this.PicNotNullScheduleName.Size = new System.Drawing.Size(14, 22);
			this.PicNotNullScheduleName.TabIndex = 0;
			this.PicNotNullScheduleName.TabStop = false;
			// 
			// Lbl_ManagerName
			// 
			this.Lbl_ManagerName.Location = new System.Drawing.Point(140, 158);
			this.Lbl_ManagerName.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_ManagerName.Name = "Lbl_ManagerName";
			this.Lbl_ManagerName.Size = new System.Drawing.Size(90, 43);
			this.Lbl_ManagerName.TabIndex = 3;
			this.Lbl_ManagerName.Text = "服务地址：";
			this.Lbl_ManagerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtServiceAddress
			// 
			this.TxtServiceAddress.BackColor = System.Drawing.Color.White;
			this.TxtServiceAddress.BoxBackColor = System.Drawing.Color.White;
			this.TxtServiceAddress.Location = new System.Drawing.Point(230, 170);
			this.TxtServiceAddress.MaxLength = 255;
			this.TxtServiceAddress.Multiline = false;
			this.TxtServiceAddress.Name = "TxtServiceAddress";
			this.TxtServiceAddress.Padding = new System.Windows.Forms.Padding(1);
			this.TxtServiceAddress.PasswordChar = '\0';
			this.TxtServiceAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtServiceAddress.Size = new System.Drawing.Size(352, 27);
			this.TxtServiceAddress.TabIndex = 0;
			// 
			// Lbl_ContactPhone
			// 
			this.Lbl_ContactPhone.Location = new System.Drawing.Point(140, 198);
			this.Lbl_ContactPhone.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_ContactPhone.Name = "Lbl_ContactPhone";
			this.Lbl_ContactPhone.Size = new System.Drawing.Size(90, 43);
			this.Lbl_ContactPhone.TabIndex = 3;
			this.Lbl_ContactPhone.Text = "任务状态：";
			this.Lbl_ContactPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Lbl_NoteDescription
			// 
			this.Lbl_NoteDescription.Location = new System.Drawing.Point(137, 435);
			this.Lbl_NoteDescription.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_NoteDescription.Name = "Lbl_NoteDescription";
			this.Lbl_NoteDescription.Size = new System.Drawing.Size(90, 43);
			this.Lbl_NoteDescription.TabIndex = 3;
			this.Lbl_NoteDescription.Text = "备注说明：";
			this.Lbl_NoteDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PicTitleLine
			// 
			this.PicTitleLine.Image = global::ScheduleJobDesktop.Properties.Resources.TitleLine;
			this.PicTitleLine.Location = new System.Drawing.Point(140, 65);
			this.PicTitleLine.Margin = new System.Windows.Forms.Padding(0);
			this.PicTitleLine.Name = "PicTitleLine";
			this.PicTitleLine.Size = new System.Drawing.Size(350, 22);
			this.PicTitleLine.TabIndex = 2;
			this.PicTitleLine.TabStop = false;
			// 
			// PicTitle
			// 
			this.PicTitle.Image = global::ScheduleJobDesktop.Properties.Resources.TitleManageScheduleJob_1;
			this.PicTitle.Location = new System.Drawing.Point(140, 22);
			this.PicTitle.Margin = new System.Windows.Forms.Padding(0);
			this.PicTitle.Name = "PicTitle";
			this.PicTitle.Size = new System.Drawing.Size(350, 43);
			this.PicTitle.TabIndex = 1;
			this.PicTitle.TabStop = false;
			// 
			// PicLogo
			// 
			this.PicLogo.Image = global::ScheduleJobDesktop.Properties.Resources.LogoScheduledTask;
			this.PicLogo.Location = new System.Drawing.Point(20, 22);
			this.PicLogo.Margin = new System.Windows.Forms.Padding(20, 22, 20, 22);
			this.PicLogo.Name = "PicLogo";
			this.PicLogo.Size = new System.Drawing.Size(100, 108);
			this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PicLogo.TabIndex = 0;
			this.PicLogo.TabStop = false;
			// 
			// PnlInfoTopLine
			// 
			this.PnlInfoTopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.PnlInfoTopLine.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlInfoTopLine.Location = new System.Drawing.Point(0, 27);
			this.PnlInfoTopLine.Name = "PnlInfoTopLine";
			this.PnlInfoTopLine.Size = new System.Drawing.Size(771, 1);
			this.PnlInfoTopLine.TabIndex = 3;
			// 
			// PnlInfoTitle
			// 
			this.PnlInfoTitle.BackColor = System.Drawing.Color.White;
			this.PnlInfoTitle.BackgroundImage = global::ScheduleJobDesktop.Properties.Resources.TableHeaderBG;
			this.PnlInfoTitle.Controls.Add(this.LblModuleTitle);
			this.PnlInfoTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlInfoTitle.Location = new System.Drawing.Point(0, 0);
			this.PnlInfoTitle.Name = "PnlInfoTitle";
			this.PnlInfoTitle.Size = new System.Drawing.Size(771, 27);
			this.PnlInfoTitle.TabIndex = 2;
			// 
			// LblModuleTitle
			// 
			this.LblModuleTitle.BackColor = System.Drawing.Color.Transparent;
			this.LblModuleTitle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LblModuleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.LblModuleTitle.Location = new System.Drawing.Point(5, 1);
			this.LblModuleTitle.Name = "LblModuleTitle";
			this.LblModuleTitle.Size = new System.Drawing.Size(300, 25);
			this.LblModuleTitle.TabIndex = 1;
			this.LblModuleTitle.Text = "任务管理";
			this.LblModuleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PnlFooter
			// 
			this.PnlFooter.BackgroundImage = global::ScheduleJobDesktop.Properties.Resources.FooterBG;
			this.PnlFooter.Controls.Add(this.BtnSave);
			this.PnlFooter.Controls.Add(this.BtnCancel);
			this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlFooter.Location = new System.Drawing.Point(0, 596);
			this.PnlFooter.Name = "PnlFooter";
			this.PnlFooter.Size = new System.Drawing.Size(830, 54);
			this.PnlFooter.TabIndex = 3;
			// 
			// BtnSave
			// 
			this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
			this.BtnSave.Location = new System.Drawing.Point(642, 13);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Padding = new System.Windows.Forms.Padding(1);
			this.BtnSave.Size = new System.Drawing.Size(82, 26);
			this.BtnSave.TabIndex = 2;
			this.BtnSave.Text = "保存";
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
			this.BtnCancel.Location = new System.Drawing.Point(730, 13);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Padding = new System.Windows.Forms.Padding(1);
			this.BtnCancel.Size = new System.Drawing.Size(82, 26);
			this.BtnCancel.TabIndex = 1;
			this.BtnCancel.Text = "返回";
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// ScheduleJobEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.PnlScrollArea);
			this.Controls.Add(this.PnlFooter);
			this.Name = "ScheduleJobEdit";
			this.Size = new System.Drawing.Size(830, 650);
			this.PnlScrollArea.ResumeLayout(false);
			this.PnlInfo.ResumeLayout(false);
			this.PnlInfoBack.ResumeLayout(false);
			this.PnlControlArea.ResumeLayout(false);
			this.PnlJobState.ResumeLayout(false);
			this.PnlJobState.PerformLayout();
			this.PnlInterval.ResumeLayout(false);
			this.PnlInterval.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicNotNullScheduleServiceURL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicNotNullScheduleName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
			this.PnlInfoTitle.ResumeLayout(false);
			this.PnlFooter.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlScrollArea;
        private System.Windows.Forms.Panel SpaceBottom;
        private System.Windows.Forms.Panel PnlInfo;
        private System.Windows.Forms.Panel PnlInfoBack;
        private System.Windows.Forms.Panel PnlControlArea;
        private System.Windows.Forms.PictureBox PicTitleLine;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PnlInfoTopLine;
        private System.Windows.Forms.Panel PnlInfoTitle;
        private System.Windows.Forms.Label LblModuleTitle;
        private System.Windows.Forms.Panel PnlFooter;
        private ScheduleJobDesktop.UserControls.Button BtnSave;
        private ScheduleJobDesktop.UserControls.Button BtnCancel;
        private System.Windows.Forms.Label Lbl_ScheduleName;
        private System.Windows.Forms.PictureBox PicNotNullScheduleName;
        private System.Windows.Forms.Label Lbl_ManagerName;
        ScheduleJobDesktop.UI.UserControls.TextBox TxtServiceAddress;
        private System.Windows.Forms.Label Lbl_ContactPhone;
        private System.Windows.Forms.Label Lbl_NoteDescription;
        ScheduleJobDesktop.UI.UserControls.TextBox TxtNoteDescription;
        private System.Windows.Forms.PictureBox PicNotNullScheduleServiceURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.TextBox TxtJobIdentity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComBoxFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimePickerEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimePickerStart;
        private System.Windows.Forms.Label label6;
        private UserControls.TextBox TxtScheduleChineseName;
        private System.Windows.Forms.RadioButton RadioBtnStopping;
        private System.Windows.Forms.RadioButton RadioBtnWaiting;
        private System.Windows.Forms.RadioButton RadioBtnRunning;
        private System.Windows.Forms.Label label8;
        private UserControls.TextBox TxtHour;
        private System.Windows.Forms.RadioButton RadioBtnHour;
        private System.Windows.Forms.Label label7;
        private UserControls.TextBox TxtDay;
        private System.Windows.Forms.RadioButton RadioBtnDay;
        private System.Windows.Forms.Label label9;
        private UserControls.TextBox TxtMinute;
        private System.Windows.Forms.RadioButton RadioBtnMinute;
        private System.Windows.Forms.Panel PnlJobState;
        private System.Windows.Forms.Panel PnlInterval;
    }
}
