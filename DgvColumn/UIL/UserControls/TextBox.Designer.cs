namespace BudStudio.DgvColumn.UIL.UserControls
{
    partial class TextBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            this.PnlBorder = new System.Windows.Forms.Panel();
            this.PnlWhiteBG = new System.Windows.Forms.Panel();
            this.PnlImageBG = new System.Windows.Forms.Panel();
            this.TxtInside = new System.Windows.Forms.TextBox();
            this.PnlBorder.SuspendLayout();
            this.PnlWhiteBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBorder
            // 
            this.PnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PnlBorder.Controls.Add(this.PnlWhiteBG);
            this.PnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBorder.Location = new System.Drawing.Point(1, 1);
            this.PnlBorder.Name = "PnlBorder";
            this.PnlBorder.Padding = new System.Windows.Forms.Padding(1);
            this.PnlBorder.Size = new System.Drawing.Size(198, 25);
            this.PnlBorder.TabIndex = 0;
            // 
            // PnlWhiteBG
            // 
            this.PnlWhiteBG.BackColor = System.Drawing.Color.White;
            this.PnlWhiteBG.Controls.Add(this.TxtInside);
            this.PnlWhiteBG.Controls.Add(this.PnlImageBG);
            this.PnlWhiteBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlWhiteBG.Location = new System.Drawing.Point(1, 1);
            this.PnlWhiteBG.Name = "PnlWhiteBG";
            this.PnlWhiteBG.Size = new System.Drawing.Size(196, 23);
            this.PnlWhiteBG.TabIndex = 0;
            // 
            // PnlImageBG
            // 
            this.PnlImageBG.BackColor = System.Drawing.Color.White;
            this.PnlImageBG.BackgroundImage = global::BudStudio.DgvColumn.Properties.Resources.Input;
            this.PnlImageBG.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlImageBG.Location = new System.Drawing.Point(0, 0);
            this.PnlImageBG.Name = "PnlImageBG";
            this.PnlImageBG.Size = new System.Drawing.Size(196, 3);
            this.PnlImageBG.TabIndex = 1;
            // 
            // TxtInside
            // 
            this.TxtInside.BackColor = System.Drawing.Color.White;
            this.TxtInside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInside.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TxtInside.Location = new System.Drawing.Point(3, 6);
            this.TxtInside.Name = "TxtInside";
            this.TxtInside.Size = new System.Drawing.Size(190, 14);
            this.TxtInside.TabIndex = 2;
            // 
            // TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlBorder);
            this.Name = "TextBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(200, 27);
            this.PnlBorder.ResumeLayout(false);
            this.PnlWhiteBG.ResumeLayout(false);
            this.PnlWhiteBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBorder;
        private System.Windows.Forms.Panel PnlWhiteBG;
        private System.Windows.Forms.Panel PnlImageBG;
        private System.Windows.Forms.TextBox TxtInside;
    }
}
