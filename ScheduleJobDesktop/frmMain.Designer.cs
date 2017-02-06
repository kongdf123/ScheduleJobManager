namespace ScheduleJobDesktop
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menu = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelScheduleJob = new System.Windows.Forms.Panel();
            this.linkScheduleJobEdit = new System.Windows.Forms.LinkLabel();
            this.linkScheduleJobList = new System.Windows.Forms.LinkLabel();
            this.menuScheduleJob = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.任务列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuContainer = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusStrip1.SuspendLayout();
            this.tabContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelScheduleJob.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelMenuContainer.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1074, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "单位：xx公司";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(100, 3, 1, 3);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tabPage1);
            this.tabContainer.Location = new System.Drawing.Point(123, 27);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(947, 455);
            this.tabContainer.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.menu.Location = new System.Drawing.Point(1, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(125, 23);
            this.menu.TabIndex = 3;
            this.menu.Text = "系统设置";
            this.menu.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(235, 158);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 0;
            // 
            // panelScheduleJob
            // 
            this.panelScheduleJob.BackColor = System.Drawing.SystemColors.Window;
            this.panelScheduleJob.Controls.Add(this.linkScheduleJobEdit);
            this.panelScheduleJob.Controls.Add(this.linkScheduleJobList);
            this.panelScheduleJob.Controls.Add(this.menuScheduleJob);
            this.panelScheduleJob.Location = new System.Drawing.Point(0, 0);
            this.panelScheduleJob.Name = "panelScheduleJob";
            this.panelScheduleJob.Size = new System.Drawing.Size(125, 98);
            this.panelScheduleJob.TabIndex = 3;
            // 
            // linkScheduleJobEdit
            // 
            this.linkScheduleJobEdit.AutoSize = true;
            this.linkScheduleJobEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkScheduleJobEdit.LinkColor = System.Drawing.Color.Black;
            this.linkScheduleJobEdit.Location = new System.Drawing.Point(23, 61);
            this.linkScheduleJobEdit.Name = "linkScheduleJobEdit";
            this.linkScheduleJobEdit.Size = new System.Drawing.Size(70, 13);
            this.linkScheduleJobEdit.TabIndex = 2;
            this.linkScheduleJobEdit.TabStop = true;
            this.linkScheduleJobEdit.Text = ">> 添加任务";
            this.linkScheduleJobEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkScheduleJobEdit_LinkClicked);
            // 
            // linkScheduleJobList
            // 
            this.linkScheduleJobList.AutoSize = true;
            this.linkScheduleJobList.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkScheduleJobList.LinkColor = System.Drawing.Color.Black;
            this.linkScheduleJobList.Location = new System.Drawing.Point(22, 38);
            this.linkScheduleJobList.Name = "linkScheduleJobList";
            this.linkScheduleJobList.Size = new System.Drawing.Size(70, 13);
            this.linkScheduleJobList.TabIndex = 1;
            this.linkScheduleJobList.TabStop = true;
            this.linkScheduleJobList.Text = ">> 任务列表";
            this.linkScheduleJobList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkScheduleJobList_LinkClicked);
            // 
            // menuScheduleJob
            // 
            this.menuScheduleJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.menuScheduleJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuScheduleJob.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuScheduleJob.Location = new System.Drawing.Point(0, 0);
            this.menuScheduleJob.Name = "menuScheduleJob";
            this.menuScheduleJob.Size = new System.Drawing.Size(125, 23);
            this.menuScheduleJob.TabIndex = 0;
            this.menuScheduleJob.Text = "任务管理";
            this.menuScheduleJob.UseVisualStyleBackColor = false;
            this.menuScheduleJob.Click += new System.EventHandler(this.menuScheduleJob_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 17);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜单";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 24);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.任务ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 任务ToolStripMenuItem
            // 
            this.任务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.任务列表ToolStripMenuItem,
            this.添加任务ToolStripMenuItem});
            this.任务ToolStripMenuItem.Name = "任务ToolStripMenuItem";
            this.任务ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.任务ToolStripMenuItem.Text = "任务";
            // 
            // 任务列表ToolStripMenuItem
            // 
            this.任务列表ToolStripMenuItem.Name = "任务列表ToolStripMenuItem";
            this.任务列表ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.任务列表ToolStripMenuItem.Text = "任务列表";
            // 
            // 添加任务ToolStripMenuItem
            // 
            this.添加任务ToolStripMenuItem.Name = "添加任务ToolStripMenuItem";
            this.添加任务ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.添加任务ToolStripMenuItem.Text = "添加任务";
            // 
            // panelMenuContainer
            // 
            this.panelMenuContainer.Controls.Add(this.panelSettings);
            this.panelMenuContainer.Controls.Add(this.panelScheduleJob);
            this.panelMenuContainer.Location = new System.Drawing.Point(0, 45);
            this.panelMenuContainer.Name = "panelMenuContainer";
            this.panelMenuContainer.Size = new System.Drawing.Size(125, 437);
            this.panelMenuContainer.TabIndex = 5;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.Window;
            this.panelSettings.Controls.Add(this.linkLabel1);
            this.panelSettings.Controls.Add(this.menu);
            this.panelSettings.Location = new System.Drawing.Point(0, 99);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(125, 100);
            this.panelSettings.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(22, 43);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = ">> 参数设置";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenuContainer);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.Text = "任务调度系统 V1.0";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelScheduleJob.ResumeLayout(false);
            this.panelScheduleJob.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenuContainer.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelScheduleJob;
        private System.Windows.Forms.Button menuScheduleJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkScheduleJobEdit;
        private System.Windows.Forms.LinkLabel linkScheduleJobList;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 任务列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加任务ToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenuContainer;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

