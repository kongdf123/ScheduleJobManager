namespace ScheduleJobDesktop.UI.UserControls
{
    partial class CheckBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ChkBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 25);
            this.panel1.TabIndex = 0;
            // 
            // ChkBox
            // 
            this.ChkBox.AutoSize = true;
            this.ChkBox.BackColor = System.Drawing.Color.White;
            this.ChkBox.FlatAppearance.BorderSize = 0;
            this.ChkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumTurquoise;
            this.ChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ChkBox.Location = new System.Drawing.Point(3, 3);
            this.ChkBox.Name = "ChkBox";
            this.ChkBox.Size = new System.Drawing.Size(75, 17);
            this.ChkBox.TabIndex = 0;
            this.ChkBox.Text = "CheckBox";
            this.ChkBox.UseVisualStyleBackColor = false;
            this.ChkBox.Click += new System.EventHandler(this.ChkBox_Click);
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "CheckBox";
            this.Size = new System.Drawing.Size(87, 31);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ChkBox;
    }
}
