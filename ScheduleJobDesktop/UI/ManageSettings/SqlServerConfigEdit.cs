using System;
using System.Windows.Forms;
using DataAccess.Entity;
using DataAccess.BLL;
using JobMonitor.Utility;
using JobMonitor.Core.Model;

namespace JobMonitor.Desktop.UI.ManageSettings
{
    public partial class SqlServerConfigEdit : UserControl
    {
        static SqlServerConfigEdit instance;
        SqlServerConfigInfo dbConfigInfo;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static SqlServerConfigEdit Instance {
            get {
                if (instance == null)
                {
                    instance = new SqlServerConfigEdit();
                }
                instance.dbConfigInfo = new SqlServerConfigInfo(); // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
                return instance;
            }
        }

        public static SqlServerConfigEdit BindJobDetail(SqlServerConfigInfo dbConfigInfo)
        {
            if (instance == null)
            {
                instance = new SqlServerConfigEdit();
            }
            instance.dbConfigInfo = dbConfigInfo; // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
            instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
            return instance;
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private SqlServerConfigEdit()
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
            if (dbConfigInfo.Id > 0)
            {
                SqlServerConfigInfoBLL.CreateInstance().Update(dbConfigInfo);
            }
            else
            {
                SqlServerConfigInfoBLL.CreateInstance().Insert(dbConfigInfo);
            }

            FormSysMessage.ShowSuccessMsg("保存成功，单击“确定”按钮返回列表。");
            FormMain.LoadNewControl(SqlServerConfigList.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“取消”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormMain.LoadNewControl(SqlServerConfigList.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }


        #region 界面控件与关联对象之间的绑定方法

        /// <summary>
        /// 将界面控件中的值，绑定给关联对象。
        /// </summary>
        private void BindFormlToObject()
        {
            dbConfigInfo.EquipmentNum = DataValid.GetNullOrString(TxtEquipmentNum.Text);
            dbConfigInfo.ServerAddress = DataValid.GetNullOrString(TxtServerIP.Text);
            dbConfigInfo.DBName = DataValid.GetNullOrString(TxtDBName.Text);
            dbConfigInfo.UserName = DataValid.GetNullOrString(TxtUserName.Text);
            dbConfigInfo.Password = DataValid.GetNullOrString(TxtPassword.Text);
            dbConfigInfo.StoredType = GetStoredType().Item1;
            dbConfigInfo.PageSize = GetStoredType().Item2;
            dbConfigInfo.MaxCapacity = GetStoredType().Item3;
            dbConfigInfo.ServerState = GetServerState();

            if (ChkAuthenticatedType.Checked)
            {
                dbConfigInfo.AuthenticatedType = (byte)AuthenticatedType.Windows;
            }
            else
            {
                dbConfigInfo.AuthenticatedType = (byte)AuthenticatedType.SqlServer;
            }
        }

        /// <summary>
        /// 将关联对象中的值，绑定至界面控件进行显示。
        /// </summary>
        private void BindObjectToForm()
        {
            TxtEquipmentNum.Text = dbConfigInfo.EquipmentNum;
            TxtServerIP.Text = dbConfigInfo.ServerAddress;
            TxtDBName.Text = dbConfigInfo.DBName;
            TxtUserName.Text = dbConfigInfo.UserName;
            TxtPassword.Text = dbConfigInfo.Password;
            SetStoredType(dbConfigInfo.StoredType, dbConfigInfo.PageSize, dbConfigInfo.MaxCapacity);
            SetServerState(dbConfigInfo.ServerState);

            if (dbConfigInfo.AuthenticatedType == (byte)AuthenticatedType.Windows)
            {
                ChkAuthenticatedType.Checked = true;
                TxtUserName.SetDisabled();
                TxtPassword.SetDisabled();
            }
            else
            {
                ChkAuthenticatedType.Checked = false;
                TxtUserName.SetEnabled();
                TxtPassword.SetEnabled();
            }
        }

        byte GetServerState()
        {
            if (RadioBtnEnable.Checked)
            {
                return (byte)Status.Enabled;
            }
            else if (RadioBtnDisable.Checked)
            {
                return (byte)Status.Disabled;
            }
            throw new CustomException("请设置一个数据库状态。", ExceptionType.Warn);
        }

        void SetServerState(byte serverState)
        {
            if (serverState == (byte)Status.Enabled)
            {
                RadioBtnEnable.Checked = true;
            }
            else if (serverState == (byte)Status.Disabled)
            {
                RadioBtnDisable.Checked = true;
            }
        }

        Tuple<byte, int, int> GetStoredType()
        {
            if (RadioBtnPageSize.Checked)
            {
                if (!string.IsNullOrEmpty(TxtPageSize.Text))
                {
                    return Tuple.Create<byte, int, int>((byte)StoredType.PageSize, Convert.ToInt32(TxtPageSize.Text), 0);
                }
            }
            else if (RadioBtnMaxCapacity.Checked)
            {
                if (!string.IsNullOrEmpty(TxtMaxCapacity.Text))
                {
                    return Tuple.Create<byte, int, int>((byte)StoredType.MaxCapacity, 0, Convert.ToInt32(TxtMaxCapacity.Text));
                }
            }
            throw new CustomException("请选择一个存储方式并填写数据条数。", ExceptionType.Warn);
        }

        void SetStoredType(byte storedType, int pageSize, int maxCapacity)
        {
            switch (storedType)
            {
                case (byte)StoredType.PageSize:
                    RadioBtnPageSize.Checked = true;
                    TxtPageSize.Text = pageSize.ToString();
                    break;
                case (byte)StoredType.MaxCapacity:
                    RadioBtnMaxCapacity.Checked = true;
                    TxtMaxCapacity.Text = maxCapacity.ToString();
                    break;
                default:
                    break;
            }
        }

        #endregion 界面控件与关联对象之间的绑定方法

        private void ChkAuthenticatedType_CheckBoxClick(object sender, EventArgs e)
        {
            if (ChkAuthenticatedType.Checked)
            {
                TxtUserName.SetDisabled();
                TxtPassword.SetDisabled();
            }
            else
            {
                TxtUserName.SetEnabled();
                TxtPassword.SetEnabled();
            }
        }
    }
}
