namespace JobMonitor.Desktop.UI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new JobMonitor.Desktop.UI.UserControls.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new JobMonitor.Desktop.UI.UserControls.TextBox();
            this.btnSubmit = new JobMonitor.Desktop.UserControls.Button();
            this.btnReset = new JobMonitor.Desktop.UserControls.Button();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BoxBackColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(157, 73);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(1);
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.Size = new System.Drawing.Size(164, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BoxBackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(157, 127);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(1);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.Size = new System.Drawing.Size(164, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.btnSubmit.Location = new System.Drawing.Point(157, 193);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(1);
            this.btnSubmit.Size = new System.Drawing.Size(82, 26);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "登陆";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.btnReset.Location = new System.Drawing.Point(280, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(1);
            this.btnReset.Size = new System.Drawing.Size(82, 26);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackgroundImage = global::JobMonitor.Desktop.Properties.Resources.HeaderBG;
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(484, 22);
            this.PnlHeader.TabIndex = 6;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 283);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务调度系统 V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UserControls.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private UserControls.TextBox txtPassword;
        private JobMonitor.Desktop.UserControls.Button btnSubmit;
        private JobMonitor.Desktop.UserControls.Button btnReset;
        private System.Windows.Forms.Panel PnlHeader;
    }
}