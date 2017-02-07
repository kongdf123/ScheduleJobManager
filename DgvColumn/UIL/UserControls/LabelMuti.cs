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
    /// 对象名称：自定义的多行Label控件
    /// 对象说明：相对于原生的Label控件，具备了更好的UI显示效果，多行内容显示时，可以自动显示滚动条。
    /// 作者姓名：BudStudio 子水良（QQ：1541532664）
    /// 编写日期：2009/02/15 16:28:32
    /// </summary>
    [DefaultProperty("Text")]
    public partial class LabelMuti : UserControl
    {
        /// <summary>
        /// 自定义LabelMuti控件的默认实例化方法。
        /// </summary>
        public LabelMuti()
        {
            InitializeComponent();
            MutiLine = false;
            Width = 150;
            Height = 24;
            SizeChanged += new EventHandler(LabelMuti_SizeChanged);
        }

        /// <summary>
        /// 获取或设置Label上的文字。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置Label上的文字。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return LineText.Text;
            }
            set
            {
                LineText.Text = value;
                ResetInsideControl();
            }
        }

        /// <summary>
        /// 获取或设置自定义Label控件的字体。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置自定义Label控件的字体。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font TextFont
        {
            get
            {
                return LineText.Font;
            }
            set
            {
                LineText.Font = value;
            }
        }

        /// <summary>
        /// 获取或设置自定义Label控件的前景色。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置自定义Label控件字体的前景色。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextColor
        {
            get
            {
                return LineText.ForeColor;
            }
            set
            {
                LineText.ForeColor = value;
            }
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
                return LineText.LineHeight;
            }
            set
            {
                LineText.LineHeight = value;
            }
        }

        private bool mutiLine = false;
        /// <summary>
        /// 获取或设置Label是否为多行模式。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置Label是否为多行模式")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool MutiLine
        {
            get
            {
                return mutiLine;
            }
            set
            {
                mutiLine = value;
                ResetInsideControl();
            }
        }

        /// <summary>
        /// 控件大小发生变更时的事件处理方法。
        /// </summary>
        private void LabelMuti_SizeChanged(object sender, EventArgs e)
        {
            ResetInsideControl();
        }

        /// <summary>
        /// 重新设置内部控件的状态。
        /// </summary>
        private void ResetInsideControl()
        {
            if (mutiLine)
            {
                if (Height < 100) Height = 100;
                LineText.AutoHeight = true;
                LineText.MinimumSize = new Size(0, Height);
                LineText.Width = this.Width - 20;
                if (LineText.Height <= Height)
                    LineText.Width = this.Width;
                AutoScroll = true;
            }
            else
            {
                Height = 24;
                LineText.AutoHeight = false;
                LineText.MinimumSize = new Size(0, 24);
                LineText.Width = Width;
                AutoScroll = false;
            }
        }

    }


}
