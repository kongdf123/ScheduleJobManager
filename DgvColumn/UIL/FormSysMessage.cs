using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BudStudio.DgvColumn.SFL;

namespace BudStudio.DgvColumn.UIL
{
    /// <summary>
    /// 对象名称：应用程序主窗体（用户界面层）
    /// 对象说明：该窗体用于显示应用程序执行过程的提示信息及异常信息。
    /// 作者姓名：爱英思躺
    /// 编写日期：2011/12/18 20:40:20
    /// </summary>
    public partial class FormSysMessage : Form
    {
        
        private static Size detailModeSize = new Size(700, 350);


        private FormSysMessage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 显示异常信息，该方法为静态方法，可以直接进行调用。
        /// </summary>
        public static void ShowException(Exception exception)
        {
            FormSysMessage formSysMessage = new FormSysMessage();
            formSysMessage.LblMessage.Text = exception.Message;

            if (exception is CustomException)
            {
                CustomException customException = exception as CustomException;
                switch (customException.Type)
                {
                    case ExceptionType.Info: // 提示信息
                        formSysMessage.PicLogo.Image = BudStudio.DgvColumn.Properties.Resources.TipInfo;
                        formSysMessage.PicTitle.Image = BudStudio.DgvColumn.Properties.Resources.MessageInfo;
                        break;

                    case ExceptionType.Warn: // 警告信息
                        formSysMessage.PicLogo.Image = BudStudio.DgvColumn.Properties.Resources.TipWarn;
                        formSysMessage.PicTitle.Image = BudStudio.DgvColumn.Properties.Resources.MessageWarn;
                        break;

                    default:                 // 错误信息
                        formSysMessage.PicLogo.Image = BudStudio.DgvColumn.Properties.Resources.TipError;
                        formSysMessage.PicTitle.Image = BudStudio.DgvColumn.Properties.Resources.MessageError;
                        break;
                }

                // 判断是否需要显示异常的详细信息，如具体异常原因，执行的SQL语句等。可由App.Config配置。
                if (System.Configuration.ConfigurationManager.AppSettings["ShowExceptionDetail"] == "true")
                {
                    if(!string.IsNullOrEmpty(customException.DetailMessage))
                    {
                        formSysMessage.LblDetailMessage.Visible = true;
                        formSysMessage.LblDetailMessage.Text = customException.DetailMessage;
                        formSysMessage.Size = detailModeSize;
                    }
                }
            }
            formSysMessage.ShowDialog();
        }

        /// <summary>
        /// 显示操作成功类信息提示，如果App.config中的ShowSuccessMsg为false，将不显示操作成功信息。
        /// </summary>
        public static void ShowSuccessMsg(string message)
        {
            if (System.Configuration.ConfigurationManager.AppSettings["ShowSuccessMsg"] == "true")
            {
                FormSysMessage formSysMessage = new FormSysMessage();
                formSysMessage.LblMessage.Text = message;
                formSysMessage.ShowDialog();
            }
        }

        /// <summary>
        /// 显示一般类信息提示。
        /// </summary>
        public static void ShowMessage(string message)
        {
            FormSysMessage formSysMessage = new FormSysMessage();
            formSysMessage.LblMessage.Text = message;
            formSysMessage.ShowDialog();
        }

        /// <summary>
        /// 用户单击“确定”按钮时的事件处理方法。
        /// </summary>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

