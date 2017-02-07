using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BudStudio.DgvColumn.UIL.UserControls
{
    /// <summary>
    /// 对象名称：自定义的带下划线Label控件
    /// 对象说明：相对于原生的Label控件，具备了更好的UI显示效果，可以通过LineHeight设置行高并增加了下划线。
    /// 作者姓名：BudStudio 子水良（QQ：1541532664）
    /// 编写日期：2009/02/15 12:08:18
    /// </summary>
    [DefaultProperty("Text")]
    public class LabelLine : Label
    {
        private int textAreaWidth = 144;
        private int lineHeight = 24;
        private int textPadTop = 3;
        private int textHeight;
        private int showLineCount = 1;
        private List<string> textLines = new List<string>();

        /// <summary>
        /// 自定义Label控件的默认实例化方法。
        /// </summary>
        public LabelLine()
        {
            AutoSize = false;
            AutoHeight = false;
            Width = 150;
            Height = 24;
            MinimumSize = new Size(30, 24);
            SizeChanged += new EventHandler(Control_SizeChanged);
            TextChanged += new EventHandler(Control_TextChanged);
            FontChanged += new EventHandler(Control_FontChanged);
        }

        /// <summary>
        /// 获取或设置自定义Label控件的行高。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置自定义Label控件的行高。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int LineHeight
        {
            get
            {
                return lineHeight;
            }
            set
            {
                lineHeight = value;
                PreparePaintData();
                Refresh();
            }
        }

        /// <summary>
        /// 获取或设置自定义Label控件是否启用自动高度调整。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置自定义Label控件是否启用自动高度调整。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AutoHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 取消原生的AutoSize属性。
        /// </summary>
        [Browsable(false)]
        public override bool AutoSize
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 重写的重绘事件处理方法。
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawText(g);
            DrawLine(g);
        }

        /// <summary>
        /// 绘制控件上的文字。
        /// </summary>
        private void DrawText(Graphics g)
        {
            Brush textBrush = new SolidBrush(ForeColor);
            for (int n = 0; n < textLines.Count; n++)
            {
                g.DrawString(textLines[n], Font, textBrush, 3, LineHeight * n + textPadTop);
            }
        }

        /// <summary>
        /// 绘制控件上的下划线。
        /// </summary>
        private void DrawLine(Graphics g)
        {
            Pen linePen = new Pen(ForeColor);
            linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            for (int n = 0; n < showLineCount; n++)
            {
                g.DrawLine(linePen, 0, LineHeight * (n + 1) - 1, Width, LineHeight * (n + 1) - 1);
            }
        }

        /// <summary>
        /// 准备绘制前的所需数据。
        /// </summary>
        private void PreparePaintData()
        {
            textAreaWidth = this.Width - 6;
            Graphics g = Graphics.FromHwnd(this.Handle);

            SizeF textSize = g.MeasureString(this.Text, this.Font);//文本的矩形区域大小   
            textHeight = Convert.ToInt32(textSize.Height);
            textPadTop = (LineHeight - textHeight) / 2 + 2;

            textLines = new List<string>();
            string lineText = "";
            for (int n = 0; n < Text.Length; n++)
            {
                lineText += Text[n];
                string tmpText = lineText;
                if (n + 1 < Text.Length)
                {
                    tmpText += Text[n + 1];
                }

                textSize = g.MeasureString(tmpText, this.Font);
                if (Convert.ToInt32(textSize.Width) > textAreaWidth || n == Text.Length - 1)
                {
                    textLines.Add(lineText);
                    lineText = "";
                }
            }
            showLineCount = Height / LineHeight;
        }

        /// <summary>
        /// 控件Text属性发生变化时的事件处理方法。
        /// </summary>
        private void Control_TextChanged(object sender, EventArgs e)
        {
            PreparePaintData();
            if (AutoHeight)
            {
                Height = MinimumSize.Height;
                if (textLines.Count * LineHeight > Height)
                {
                    Height = textLines.Count * LineHeight;
                }
            }
            showLineCount = Height / LineHeight;
        }

        /// <summary>
        /// 控件Font属性发生变化时的事件处理方法。
        /// </summary>
        private void Control_FontChanged(object sender, EventArgs e)
        {
            PreparePaintData();
        }

        /// <summary>
        /// 控件Size属性发生变化时的事件处理方法。
        /// </summary>
        private void Control_SizeChanged(object sender, EventArgs e)
        {
            PreparePaintData();
        }


    }
}
