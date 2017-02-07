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
    /// 对象名称：自定义的Button控件
    /// 对象说明：相对于原生的Button控件，具备了更好的UI显示效果。
    /// 作者姓名：BudStudio 子水良（QQ：1541532664）
    /// 编写日期：2009/01/20 16:12:39
    /// </summary>
    [DefaultEvent("Click")]
    [DefaultProperty("Text")]
    public partial class Button : UserControl
    {


        /// <summary>
        /// 自定义Button控件的默认实例化方法。使用本自定义Button控件前，请确保应用程序的
        /// Properties.Resources资源文件中，包含了2张分别名为：ButtonBG01、ButtonBG02的图片。
        /// </summary>
        public Button()
        {
            InitializeComponent();
            LblText.MouseMove += new MouseEventHandler(LblText_MouseMove);
            LblText.MouseLeave += new EventHandler(LblText_MouseLeave);
            LblText.Click += new EventHandler(LblText_Click);
        }

        /// <summary>
        /// 获取或设置按钮上的文字。
        /// </summary>
        [Category("设置")]
        [Description("获取或设置按钮上的文字。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return LblText.Text;
            }
            set
            {
                LblText.Text = value;
            }
        }

        /// <summary>
        /// 用户单击按钮上的文字时，触发按钮的单击事件。
        /// </summary>
        void LblText_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        /// <summary>
        /// 鼠标从按钮上移开时，改变相关子控件的颜色。
        /// </summary>
        void LblText_MouseLeave(object sender, EventArgs e)
        {
            PnlBG.BackgroundImage = BudStudio.DgvColumn.Properties.Resources.ButtonBG01;
            LblText.ForeColor = Color.FromArgb(102, 102, 102);
            BackColor = Color.FromArgb(135, 163, 193);
        }

        /// <summary>
        /// 鼠标移动到按钮上时，改变相关子控件的颜色。
        /// </summary>
        void LblText_MouseMove(object sender, MouseEventArgs e)
        {
            PnlBG.BackgroundImage = BudStudio.DgvColumn.Properties.Resources.ButtonBG02;
            LblText.ForeColor = Color.FromArgb(102, 51, 0);
            BackColor = Color.FromArgb(162, 144, 77);
        }

        /// <summary>
        /// Button控件大小改变时的事件处理。
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Height = 26;
        }


    }
}

