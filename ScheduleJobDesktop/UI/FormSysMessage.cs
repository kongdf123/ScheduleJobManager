using ScheduleJobDesktop.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleJobDesktop
{
    public partial class FormSysMessage : Form
    {
        private static Size detailModeSize = new Size(700, 350);

        public FormSysMessage() {
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
                        formSysMessage.PicLogo.Image = ScheduleJobDesktop.Properties.Resources.TipInfo;
                        formSysMessage.PicTitle.Image = ScheduleJobDesktop.Properties.Resources.MessageInfo;
                        break;

                    case ExceptionType.Warn: // 警告信息
                        formSysMessage.PicLogo.Image = ScheduleJobDesktop.Properties.Resources.TipWarn;
                        formSysMessage.PicTitle.Image = ScheduleJobDesktop.Properties.Resources.MessageWarn;
                        break;

                    default:                 // 错误信息
                        formSysMessage.PicLogo.Image = ScheduleJobDesktop.Properties.Resources.TipError;
                        formSysMessage.PicTitle.Image = ScheduleJobDesktop.Properties.Resources.MessageError;
                        break;
                }

                // 判断是否需要显示异常的详细信息，如具体异常原因，执行的SQL语句等。可由App.Config配置。
                if (System.Configuration.ConfigurationManager.AppSettings["ShowExceptionDetail"] == "true")
                {
                    if (!string.IsNullOrEmpty(customException.DetailMessage))
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

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
