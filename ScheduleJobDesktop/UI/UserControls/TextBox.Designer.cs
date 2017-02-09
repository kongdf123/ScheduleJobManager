namespace ScheduleJobDesktop.UI.UserControls
{
    partial class TextBox
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
            this.PnlBorder = new System.Windows.Forms.Panel();
            this.PnlWhiteBG = new System.Windows.Forms.Panel();
            this.TxtInside = new System.Windows.Forms.TextBox();
            this.PnlImageBG = new System.Windows.Forms.Panel();
            this.PnlBorder.SuspendLayout();
            this.PnlWhiteBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBorder
            // 
            this.PnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PnlBorder.Controls.Add(this.PnlWhiteBG);
            this.PnlBorder.Controls.Add(this.PnlImageBG);
            this.PnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBorder.Location = new System.Drawing.Point(1, 1);
            this.PnlBorder.Name = "PnlBorder";
            this.PnlBorder.Padding = new System.Windows.Forms.Padding(1);
            this.PnlBorder.Size = new System.Drawing.Size(198, 27);
            this.PnlBorder.TabIndex = 0;
            // 
            // PnlWhiteBG
            // 
            this.PnlWhiteBG.BackColor = System.Drawing.Color.White;
            this.PnlWhiteBG.Controls.Add(this.TxtInside);
            this.PnlWhiteBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlWhiteBG.Location = new System.Drawing.Point(1, 4);
            this.PnlWhiteBG.Name = "PnlWhiteBG";
            this.PnlWhiteBG.Size = new System.Drawing.Size(196, 22);
            this.PnlWhiteBG.TabIndex = 0;
            // 
            // TxtInside
            // 
            this.TxtInside.BackColor = System.Drawing.Color.White;
            this.TxtInside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInside.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TxtInside.Location = new System.Drawing.Point(3, 7);
            this.TxtInside.Name = "TxtInside";
            this.TxtInside.Size = new System.Drawing.Size(190, 13);
            this.TxtInside.TabIndex = 2;
            // 
            // PnlImageBG
            // 
            this.PnlImageBG.BackgroundImage = global::ScheduleJobDesktop.Properties.Resources.Input;
            this.PnlImageBG.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlImageBG.Location = new System.Drawing.Point(1, 1);
            this.PnlImageBG.Name = "PnlImageBG";
            this.PnlImageBG.Size = new System.Drawing.Size(196, 3);
            this.PnlImageBG.TabIndex = 1;
            // 
            // TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlBorder);
            this.Name = "TextBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(200, 29);
            this.PnlBorder.ResumeLayout(false);
            this.PnlWhiteBG.ResumeLayout(false);
            this.PnlWhiteBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBorder;
        private System.Windows.Forms.Panel PnlWhiteBG;
        private System.Windows.Forms.TextBox TxtInside;
        private System.Windows.Forms.Panel PnlImageBG;
    }
}
