namespace ScheduleJobDesktop.ScheduleJob
{
    partial class ScheduleJobListControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateScheduleJob = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ScheduleJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnCreateScheduleJob);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 429);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateScheduleJob
            // 
            this.btnCreateScheduleJob.Location = new System.Drawing.Point(610, 23);
            this.btnCreateScheduleJob.Name = "btnCreateScheduleJob";
            this.btnCreateScheduleJob.Size = new System.Drawing.Size(75, 23);
            this.btnCreateScheduleJob.TabIndex = 3;
            this.btnCreateScheduleJob.Text = "新增任务";
            this.btnCreateScheduleJob.UseVisualStyleBackColor = true;
            this.btnCreateScheduleJob.Click += new System.EventHandler(this.btnCreateScheduleJob_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(506, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "任务名称";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(5, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 291);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleJobName,
            this.UpdateTime,
            this.JobStatus,
            this.BeginTime,
            this.EndTime,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "共";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "条记录，每页";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "条，共";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "页";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "|<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(847, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = ">|";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(804, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(719, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(760, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 14;
            // 
            // ScheduleJobName
            // 
            this.ScheduleJobName.HeaderText = "任务名称";
            this.ScheduleJobName.Name = "ScheduleJobName";
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "更新时间";
            this.UpdateTime.Name = "UpdateTime";
            // 
            // JobStatus
            // 
            this.JobStatus.HeaderText = "任务状态";
            this.JobStatus.Name = "JobStatus";
            // 
            // BeginTime
            // 
            this.BeginTime.HeaderText = "开始时间";
            this.BeginTime.Name = "BeginTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "结束时间";
            this.EndTime.Name = "EndTime";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "查看";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = "查看";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "删除";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "修改";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "暂停";
            this.Column4.Name = "Column4";
            // 
            // ScheduleJobListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ScheduleJobListControl";
            this.Size = new System.Drawing.Size(939, 429);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreateScheduleJob;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
    }
}
