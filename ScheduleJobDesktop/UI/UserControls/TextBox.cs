using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleJobDesktop.UI.UserControls
{
    /// <summary>
    /// 自定义输入框
    /// </summary>
    [DefaultProperty("Text")]
    public partial class TextBox : UserControl
    {
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
        [Category("输入字符最大长度")]
        [Description("获取或设置文本框中的内容字符最大长度。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int MaxLength {
            get {
                return TxtInside.MaxLength;
            }
            set {
                TxtInside.MaxLength = value;
            }
        }


        /// <summary>
        /// 获取或设置文本框中的内容。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置文本框中的内容。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text {
            get {
                return TxtInside.Text;
            }
            set {
                TxtInside.Text = value;
            }
        }

        /// <summary>
        /// 获取或设置是否为多行文本框。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置是否为多行文本框。")]
        [Browsable(true)]
        public bool Multiline {
            get {
                return TxtInside.Multiline;
            }
            set {
                TxtInside.Multiline = value;

            }
        }

        /// <summary>
        /// 获取或设置文本框的滚动条显示方式。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置文本框的滚动条显示方式。")]
        [Browsable(true)]
        public ScrollBars ScrollBars {
            get {
                return TxtInside.ScrollBars;
            }
            set {
                TxtInside.ScrollBars = value;

            }
        }

        /// <summary>
        /// 获取或设置密码字符。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置密码字符。")]
        [Browsable(true)]
        public char PasswordChar {
            get {
                return TxtInside.PasswordChar;
            }
            set {
                TxtInside.PasswordChar = value;

            }
        }


        /// <summary>
        /// 获取或设置背景色。
        /// </summary>
        [Category("设置")]
        [Description("设置背景色。")]
        [Browsable(true)]
        public Color BoxBackColor {
            get {
                return TxtInside.BackColor;
            }
            set {
                BackColor = value;
                PnlWhiteBG.BackColor = value;
                TxtInside.BackColor = value;
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

        public void SetDisabled()
        {
            Enabled = false;
            BoxBackColor = Color.FromArgb(245, 245, 245);
        }

        public void SetEnabled()
        {
            Enabled = true;
            BoxBackColor = Color.White;
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

        private void TxtInside_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65296 && e.KeyChar <= 65305)
            {
                e.KeyChar -= Convert.ToChar(65248);
            }
        }
    }
}
