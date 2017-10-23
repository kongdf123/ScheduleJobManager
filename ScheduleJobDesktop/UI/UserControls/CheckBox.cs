using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JobMonitor.Desktop.UI.UserControls
{
    [DefaultProperty("Text")]
    public partial class CheckBox : UserControl
    {
        public event EventHandler CheckBoxClick; //事件：控件的当前页码发生变更。
        public CheckBox()
        {
            InitializeComponent();
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
                return ChkBox.Text;
            }
            set {
                ChkBox.Text = value;
            }
        }

        /// <summary>
        /// 获取或设置文本框中的内容。
        /// </summary>
        [Category("勾选状态")]
        [Description("获取或设置勾选状态")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Checked {
            get {
                return ChkBox.Checked;
            }
            set {
                ChkBox.Checked = value;
            }
        }

        private void ChkBox_Click(object sender, EventArgs e)
        {
            if (CheckBoxClick != null)
            {
                CheckBoxClick(sender, e);
            }
        }
    }
}
