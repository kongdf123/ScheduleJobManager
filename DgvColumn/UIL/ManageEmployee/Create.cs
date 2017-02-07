using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BudStudio.DgvColumn.BLL;
using BudStudio.DgvColumn.COL;
using BudStudio.DgvColumn.SFL;

namespace BudStudio.DgvColumn.UIL.ManageEmployee
{
    /// <summary>
    /// 对象名称：“员工信息管理模块”添加界面控件（用户界面层）
    /// 对象说明：该界面用于添加“员工信息”对象至数据库，添加操作成功后返回列表界面。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012/02/29 16:07:34
    /// </summary>
    public partial class Create : UserControl
    {
        private Employee employee;
        private static Create instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Create Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Create();
                }
                instance.employee = new Employee(); // 创建新的关联对象，可以在“数据实体层”中指定对象的默认值。
                instance.InitControl();      // 每次返回该控件的实例前，都将对下拉框等界面显示控件的数据源进行初始化。
                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象的默认值，绑定至界面控件进行显示。
                return instance;
            }
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private Create()
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
            EmployeeBLL.Insert(employee); // 调用“业务逻辑层”的方法，检查有效性后插入至数据库。
            FormSysMessage.ShowSuccessMsg("“员工信息”添加成功，单击“确定”按钮返回信息列表。");
            Default.GotoLastPage();                    // 将该模块的信息列表的页码转至最后一页。
            FormMain.LoadNewControl(Default.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“取消”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormMain.LoadNewControl(Default.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }


        #region 界面控件与关联对象之间的绑定方法

        /// <summary>
        /// 初始化下拉框等控件的数据源。
        /// </summary>
        private void InitControl()
        {
            //指定“性别”下拉框的数据源
            DrpSex.DisplayMember = "Name";
            DrpSex.ValueMember = "Id";
            DrpSex.DataSource = Sex.AllList;

            //指定“所在部门”下拉框的数据源
            DrpDepartment.DisplayMember = "DepartmentName";
            DrpDepartment.ValueMember = "Id";
            DrpDepartment.DataSource = BLL.DepartmentBLL.GetAllList();

        }

        /// <summary>
        /// 将界面控件中的值，绑定给关联对象。
        /// </summary>
        private void BindFormlToObject()
        {
            if (!DataValid.IsNullOrInt(DrpSex.SelectedValue.ToString()))
                throw new CustomException("“性别”的编号，不是一个有效的整数，请您重新输入。");

            if (!DataValid.IsNullOrDateTime(TxtDateOfBirth.Text))
                throw new CustomException("“出生日期”不是一个有效格式的日期，正确格式应为“"+DateTime.Now.ToString("yyyy-MM-dd")+"”，请您重新输入。");

            if (!DataValid.IsNullOrInt(DrpDepartment.SelectedValue.ToString()))
                throw new CustomException("“所在部门”的自动编号，不是一个有效的整数，请您重新输入。");

            employee.BadgeId = DataValid.GetNullOrString(TxtBadgeId.Text);  // 工号
            employee.Name = DataValid.GetNullOrString(TxtName.Text);  // 姓名
            employee.Sex = Sex.GetDataById(DataValid.GetNullOrInt(DrpSex.SelectedValue.ToString()).Value);  // 性别
            employee.DateOfBirth = DataValid.GetNullOrDateTime(TxtDateOfBirth.Text);  // 出生日期
            employee.IDCardId = DataValid.GetNullOrString(TxtIDCardId.Text);  // 身份证号
            employee.Nationa = DataValid.GetNullOrString(TxtNationa.Text);  // 民族
            employee.PoliticalLandscape = DataValid.GetNullOrString(TxtPoliticalLandscape.Text);  // 政治面貌
            employee.MaritalStatus = DataValid.GetNullOrString(TxtMaritalStatus.Text);  // 婚姻状况
            employee.PlaceOfHouseholdRegistration = DataValid.GetNullOrString(TxtPlaceOfHouseholdRegistration.Text);  // 户口所在地
            employee.Department = (DataValid.GetNullOrInt(DrpDepartment.SelectedValue.ToString()) != null) ? DepartmentBLL.GetDataById(DataValid.GetNullOrInt(DrpDepartment.SelectedValue.ToString()).Value) : null;  // 所在部门
            employee.ResidenceAddress = DataValid.GetNullOrString(TxtResidenceAddress.Text);  // 现居住住址
            employee.GraduateSchool = DataValid.GetNullOrString(TxtGraduateSchool.Text);  // 毕业学校
            employee.FieldOfStudy = DataValid.GetNullOrString(TxtFieldOfStudy.Text);  // 所学专业
            employee.GraduationDate = DataValid.GetNullOrString(TxtGraduationDate.Text);  // 毕业时间
            employee.AcademicQualifications = DataValid.GetNullOrString(TxtAcademicQualifications.Text);  // 学历
            employee.ContactPhone = DataValid.GetNullOrString(TxtContactPhone.Text);  // 联系电话
            employee.EmergencyContacts = DataValid.GetNullOrString(TxtEmergencyContacts.Text);  // 紧急联系人
            employee.EmergencyTelephone = DataValid.GetNullOrString(TxtEmergencyTelephone.Text);  // 紧急电话
        }

        /// <summary>
        /// 将关联对象中的值，绑定至界面控件进行显示。
        /// </summary>
        private void BindObjectToForm()
        {
            TxtBadgeId.Text = employee.BadgeId;  // 工号
            TxtName.Text = employee.Name;  // 姓名
            if (employee.Sex != null) DrpSex.SelectedValue = employee.Sex.Id ;
            TxtDateOfBirth.Text = employee.DateOfBirth.HasValue ? employee.DateOfBirth.Value.ToString("yyyy-MM-dd") : null;  // 出生日期
            TxtIDCardId.Text = employee.IDCardId;  // 身份证号
            TxtNationa.Text = employee.Nationa;  // 民族
            TxtPoliticalLandscape.Text = employee.PoliticalLandscape;  // 政治面貌
            TxtMaritalStatus.Text = employee.MaritalStatus;  // 婚姻状况
            TxtPlaceOfHouseholdRegistration.Text = employee.PlaceOfHouseholdRegistration;  // 户口所在地
            if (employee.Department != null) DrpDepartment.SelectedValue = employee.Department.Id ;
            TxtResidenceAddress.Text = employee.ResidenceAddress;  // 现居住住址
            TxtGraduateSchool.Text = employee.GraduateSchool;  // 毕业学校
            TxtFieldOfStudy.Text = employee.FieldOfStudy;  // 所学专业
            TxtGraduationDate.Text = employee.GraduationDate;  // 毕业时间
            TxtAcademicQualifications.Text = employee.AcademicQualifications;  // 学历
            TxtContactPhone.Text = employee.ContactPhone;  // 联系电话
            TxtEmergencyContacts.Text = employee.EmergencyContacts;  // 紧急联系人
            TxtEmergencyTelephone.Text = employee.EmergencyTelephone;  // 紧急电话
        }

        #endregion 界面控件与关联对象之间的绑定方法


    }
}
