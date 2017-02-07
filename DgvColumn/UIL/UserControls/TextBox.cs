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
    /// 对象名称：自定义的TextBox控件
    /// 对象说明：相对于原生的TextBox控件，具备了更好的UI显示效果。
    /// 作者姓名：BudStudio 子水良（QQ：1541532664）
    /// 编写日期：2009/01/20 12:08:18
    /// </summary>
    [DefaultProperty("Text")]
    public partial class TextBox : UserControl
    {


        /// <summary>
        /// 自定义TextBox控件的默认实例化方法。使用本自定义Button控件前，请确保
        /// 应用程序的Properties.Resources资源文件中，包含了1张名为Input的图片。
        /// </summary>
        public TextBox()
        {
            InitializeComponent();
            TxtInside.BackColor = Color.White;
            TxtInside.Location = new Point(3, 6);
            TxtInside.Width = PnlWhiteBG.Width - 6;
            TxtInside.GotFocus += new EventHandler(TxtBox_GotFocus);
            TxtInside.Leave += new EventHandler(TxtBox_Leave);
        }

        /// <summary>
        /// 获取或设置文本框中的内容。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置文本框中的内容。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return TxtInside.Text;
            }
            set
            {
                TxtInside.Text = value;
            }
        }

        /// <summary>
        /// 获取或设置是否为多行文本框。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置是否为多行文本框。")]
        [Browsable(true)]
        public bool Multiline
        {
            get
            {
                return TxtInside.Multiline;
            }
            set
            {
                TxtInside.Multiline = value;

            }
        }

        /// <summary>
        /// 获取或设置文本框的滚动条显示方式。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置文本框的滚动条显示方式。")]
        [Browsable(true)]
        public ScrollBars ScrollBars
        {
            get
            {
                return TxtInside.ScrollBars;
            }
            set
            {
                TxtInside.ScrollBars = value;

            }
        }

        /// <summary>
        /// 获取或设置密码字符。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置密码字符。")]
        [Browsable(true)]
        public char PasswordChar
        {
            get
            {
                return TxtInside.PasswordChar;
            }
            set
            {
                TxtInside.PasswordChar = value;

            }
        }

        /// <summary>
        /// 输入焦点丢失时，改变相关子控件的颜色。
        /// </summary>
        void TxtBox_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            PnlBorder.BackColor = Color.FromArgb(204, 204, 204);
            TxtInside.ForeColor = Color.FromArgb(102, 102, 102);
        }

        /// <summary>
        /// 获得输入焦点时，改变相关子控件的颜色。
        /// </summary>
        void TxtBox_GotFocus(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(179, 221, 150);
            PnlBorder.BackColor = Color.FromArgb(87, 152, 43);
            TxtInside.ForeColor = Color.FromArgb(51, 102, 0);
        }

        /// <summary>
        /// 可以手动通过该方法，使TextBox获得输入焦点。
        /// </summary>
        public new void Focus()
        {
            TxtInside.Select();
        }

        /// <summary>
        /// TextBox控件大小改变时的事件处理。
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (!Multiline)
            {
                this.Height = 27;
            }
            TxtInside.Location = new Point(3, 5);
            TxtInside.Width = PnlWhiteBG.Width - 6;
            TxtInside.Height = PnlWhiteBG.Height - 10;
        }


    }
}
