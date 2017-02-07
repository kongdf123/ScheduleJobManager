namespace BudStudio.DgvColumn.UIL
{
    partial class FormSysMessage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMessage = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.PnlButtonArea = new System.Windows.Forms.Panel();
            this.LblLine = new System.Windows.Forms.Label();
            this.BtnOK = new BudStudio.DgvColumn.UIL.UserControls.Button();
            this.LblDetailMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            this.PnlButtonArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.Location = new System.Drawing.Point(140, 80);
            this.LblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(532, 40);
            this.LblMessage.TabIndex = 4;
            this.LblMessage.Text = "Message";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::BudStudio.DgvColumn.Properties.Resources.TipInfo;
            this.PicLogo.Location = new System.Drawing.Point(12, 15);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(100, 100);
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // PicTitle
            // 
            this.PicTitle.Image = global::BudStudio.DgvColumn.Properties.Resources.MessageInfo;
            this.PicTitle.Location = new System.Drawing.Point(140, 20);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(350, 42);
            this.PicTitle.TabIndex = 1;
            this.PicTitle.TabStop = false;
            // 
            // PnlButtonArea
            // 
            this.PnlButtonArea.BackColor = System.Drawing.SystemColors.Control;
            this.PnlButtonArea.Controls.Add(this.LblLine);
            this.PnlButtonArea.Controls.Add(this.BtnOK);
            this.PnlButtonArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtonArea.Location = new System.Drawing.Point(0, 192);
            this.PnlButtonArea.Name = "PnlButtonArea";
            this.PnlButtonArea.Size = new System.Drawing.Size(694, 60);
            this.PnlButtonArea.TabIndex = 7;
            // 
            // LblLine
            // 
            this.LblLine.BackColor = System.Drawing.Color.Silver;
            this.LblLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblLine.Location = new System.Drawing.Point(0, 0);
            this.LblLine.Margin = new System.Windows.Forms.Padding(0);
            this.LblLine.Name = "LblLine";
            this.LblLine.Size = new System.Drawing.Size(694, 1);
            this.LblLine.TabIndex = 7;
            this.LblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.BtnOK.Location = new System.Drawing.Point(597, 17);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Padding = new System.Windows.Forms.Padding(1);
            this.BtnOK.Size = new System.Drawing.Size(82, 26);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "确定";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblDetailMessage
            // 
            this.LblDetailMessage.Location = new System.Drawing.Point(140, 130);
            this.LblDetailMessage.Margin = new System.Windows.Forms.Padding(0);
            this.LblDetailMessage.Name = "LblDetailMessage";
            this.LblDetailMessage.Size = new System.Drawing.Size(532, 100);
            this.LblDetailMessage.TabIndex = 8;
            this.LblDetailMessage.Text = "DetailMessage";
            this.LblDetailMessage.Visible = false;
            // 
            // FormSysMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 252);
            this.Controls.Add(this.PnlButtonArea);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.PicTitle);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.LblDetailMessage);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSysMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统提示";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            this.PnlButtonArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMessage;
        private BudStudio.DgvColumn.UIL.UserControls.Button BtnOK;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.Panel PnlButtonArea;
        private System.Windows.Forms.Label LblLine;
        private System.Windows.Forms.Label LblDetailMessage;
    }
}
