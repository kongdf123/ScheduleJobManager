using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entity;
using ServiceHost.Common;
using DataAccess.BLL;

namespace ScheduleJobDesktop.UI.ManageSettings
{
    public partial class DBConfigCreate : UserControl
    {
        static DBConfigCreate instance;
        DBConfigInfo dbConfigInfo;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static DBConfigCreate Instance {
            get {
                if (instance == null)
                {
                    instance = new DBConfigCreate();
                }
                instance.dbConfigInfo = new DBConfigInfo(); // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
                return instance;
            }
        }


        public static DBConfigCreate BindJobDetail(DBConfigInfo dbConfigInfo)
        {
            if (instance == null)
            {
                instance = new DBConfigCreate();
            }
            instance.dbConfigInfo = dbConfigInfo; // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
            instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
            return instance;
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private DBConfigCreate()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 用户单击“保存”按钮时的事件处理方法。
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            BindFormlToObject(); // 进行数据绑定
            if (dbConfigInfo.Id>0)
            {
                DBConfigInfoBLL.CreateInstance().Update(dbConfigInfo);
            }
            else
            {
                DBConfigInfoBLL.CreateInstance().Insert(dbConfigInfo);
            }
            
            FormSysMessage.ShowSuccessMsg("保存成功，单击“确定”按钮返回列表。");
            //Default.GotoLastPage();                    // 将该模块的信息列表的页码转至最后一页。
            FormMain.LoadNewControl(DBConfig.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“取消”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormMain.LoadNewControl(DBConfig.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }


        #region 界面控件与关联对象之间的绑定方法

        /// <summary>
        /// 将界面控件中的值，绑定给关联对象。
        /// </summary>
        private void BindFormlToObject()
        {
            dbConfigInfo.ServerAddress = DataValid.GetNullOrString(TxtServerIP.Text);
            dbConfigInfo.DBName = DataValid.GetNullOrString(TxtDBName.Text);
            dbConfigInfo.UserName = DataValid.GetNullOrString(TxtUserName.Text);
            dbConfigInfo.Password = DataValid.GetNullOrString(TxtPassword.Text);
        }

        /// <summary>
        /// 将关联对象中的值，绑定至界面控件进行显示。
        /// </summary>
        private void BindObjectToForm()
        {
            TxtServerIP.Text = dbConfigInfo.ServerAddress;
            TxtDBName.Text = dbConfigInfo.DBName;
            TxtUserName.Text = dbConfigInfo.UserName;
            TxtPassword.Text = dbConfigInfo.Password;
        }

        #endregion 界面控件与关联对象之间的绑定方法
    }
}
