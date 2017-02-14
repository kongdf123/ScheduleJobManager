namespace ScheduleJobDesktop.UI.UserControls
{
    partial class PageBar
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
            this.LblTotalRecord = new System.Windows.Forms.Label();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnGO = new System.Windows.Forms.Button();
            this.LblCurPage = new System.Windows.Forms.Label();
            this.TextJumpPage = new System.Windows.Forms.TextBox();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTotalRecord
            // 
            this.LblTotalRecord.Location = new System.Drawing.Point(0, -1);
            this.LblTotalRecord.Name = "LblTotalRecord";
            this.LblTotalRecord.Size = new System.Drawing.Size(180, 24);
            this.LblTotalRecord.TabIndex = 5;
            this.LblTotalRecord.Text = "总记录数：0条（15条/页）";
            this.LblTotalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnPrev
            // 
            this.BtnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrev.FlatAppearance.BorderSize = 0;
            this.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrev.Image = global::ScheduleJobDesktop.Properties.Resources.PagePrev;
            this.BtnPrev.Location = new System.Drawing.Point(195, 0);
            this.BtnPrev.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(10, 24);
            this.BtnPrev.TabIndex = 1;
            this.BtnPrev.UseVisualStyleBackColor = false;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Image = global::ScheduleJobDesktop.Properties.Resources.PageNext;
            this.BtnNext.Location = new System.Drawing.Point(266, 0);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(5);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(10, 24);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLast.FlatAppearance.BorderSize = 0;
            this.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLast.Image = global::ScheduleJobDesktop.Properties.Resources.PageLast;
            this.BtnLast.Location = new System.Drawing.Point(282, 0);
            this.BtnLast.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(10, 24);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.UseVisualStyleBackColor = false;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnGO
            // 
            this.BtnGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGO.FlatAppearance.BorderSize = 0;
            this.BtnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGO.Image = global::ScheduleJobDesktop.Properties.Resources.BtnGO;
            this.BtnGO.Location = new System.Drawing.Point(328, 0);
            this.BtnGO.Name = "BtnGO";
            this.BtnGO.Size = new System.Drawing.Size(22, 24);
            this.BtnGO.TabIndex = 6;
            this.BtnGO.UseVisualStyleBackColor = false;
            this.BtnGO.Click += new System.EventHandler(this.BtnGO_Click);
            // 
            // LblCurPage
            // 
            this.LblCurPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCurPage.Location = new System.Drawing.Point(207, 0);
            this.LblCurPage.Name = "LblCurPage";
            this.LblCurPage.Size = new System.Drawing.Size(60, 24);
            this.LblCurPage.TabIndex = 4;
            this.LblCurPage.Text = "1/1";
            this.LblCurPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextJumpPage
            // 
            this.TextJumpPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextJumpPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TextJumpPage.Location = new System.Drawing.Point(296, 2);
            this.TextJumpPage.MaxLength = 100;
            this.TextJumpPage.Multiline = true;
            this.TextJumpPage.Name = "TextJumpPage";
            this.TextJumpPage.Size = new System.Drawing.Size(30, 21);
            this.TextJumpPage.TabIndex = 7;
            this.TextJumpPage.Text = "1";
            this.TextJumpPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextJumpPage.WordWrap = false;
            // 
            // BtnFirst
            // 
            this.BtnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFirst.FlatAppearance.BorderSize = 0;
            this.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFirst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnFirst.Image = global::ScheduleJobDesktop.Properties.Resources.PageFirst;
            this.BtnFirst.Location = new System.Drawing.Point(179, 0);
            this.BtnFirst.Margin = new System.Windows.Forms.Padding(5);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(11, 24);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.UseVisualStyleBackColor = false;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // PageBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TextJumpPage);
            this.Controls.Add(this.LblCurPage);
            this.Controls.Add(this.BtnGO);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.LblTotalRecord);
            this.MinimumSize = new System.Drawing.Size(350, 24);
            this.Name = "PageBar";
            this.Size = new System.Drawing.Size(350, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTotalRecord;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnGO;
        private System.Windows.Forms.Label LblCurPage;
        private System.Windows.Forms.TextBox TextJumpPage;
    }
}
