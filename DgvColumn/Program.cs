using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using BudStudio.DgvColumn.UIL;

namespace BudStudio.DgvColumn
{
static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ////
            //// 如果不希望使用App.Config文件来控制应用程序的全局配置信息，可以取消注释本段配置代码。
            //// 
            //// SqlServer 连结字符串
            //System.Configuration.ConfigurationManager.AppSettings["SqlServerConnString"] = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=HRSystem;User ID=sa;Password=";
            //// Oracle 连结字符串
            //System.Configuration.ConfigurationManager.AppSettings["OracleConnString"] = "Data Source=ORCL;User ID=system;Password=123456";
            //// OleDb 连结字符串
            //System.Configuration.ConfigurationManager.AppSettings["OleDbConnString"] = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\HRSystem.mdb";
            //// 当前使用的数据库类型。可选项为：SqlServer，Oracle，OleDb
            //System.Configuration.ConfigurationManager.AppSettings["DataBaseType"] = "SqlServer";
            //// 是否显示异常的详细信息（详细信息可能包含具体出错的SQL语句等，请在生产环境中设为false。
            //System.Configuration.ConfigurationManager.AppSettings["ShowExceptionDetail"] = "true";
            //// 是否显示操作成功信息（如添加、修改、删除记录成功后是否显示操作成功信息。）
            //System.Configuration.ConfigurationManager.AppSettings["ShowSuccessMsg"] = "true";

            //重新指定Access文件位置，而不使用配置文件中的地址。
            string dataBasePath = Application.StartupPath+"\\HRSystem.mdb";
            System.Configuration.ConfigurationManager.AppSettings["OleDbConnString"] = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataBasePath;

            // 全局异常注册
            ApplicationEventHandlerClass AppEvents = new ApplicationEventHandlerClass();
            Application.ThreadException += new ThreadExceptionEventHandler(AppEvents.OnThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain formMain = FormMain.Instance;
            Application.Run(formMain);
        }

        // 全局异常处理
        public class ApplicationEventHandlerClass
        {
            public void OnThreadException(object sender, ThreadExceptionEventArgs e)
            {
                FormSysMessage.ShowException(e.Exception); // 调用FormSysMessage窗体，显示异常信息。
            }
        }


    }
}
