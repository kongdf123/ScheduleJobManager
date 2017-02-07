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
    /// 对象名称：“员工信息管理模块”查看详细界面控件（用户界面层）
    /// 对象说明：该界面用于显示“员工信息”对象的详细信息。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012/02/29 16:07:34
    /// </summary>
    public partial class Detail : UserControl
    {
        private Employee employee;
        private static Detail instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Detail Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Detail();
                }

                if (instance.employee == null)
                    throw new CustomException("在调用本模块查看界面的实例前，必须调用Detail.LoadDataById方法，装载所要删除的关联对象。",ExceptionType.Error);

                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象当前的值，绑定至界面控件进行显示。
                return instance;
            }
        }

        /// <summary>
        /// 根据关联对象的主键，从数据库中获取关联对象信息，以备进行查看操作。
        /// </summary>
        public static void LoadDataById(string employeeId)
        {
            if (instance == null)
            {
                instance = new Detail();
            }
            instance.employee = EmployeeBLL.GetDataById(employeeId);
            if (instance.employee == null)
                throw new CustomException("对不起，所要查看的信息不存在或已删除。");
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private Detail()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 用户单击“修改”按钮时的事件处理方法。
        /// </summary>
        private void BtnModify_Click(object sender, EventArgs e)
        {
            Modify.LoadDataById(employee.Id.ToString()); // 根据关联对象的主键，从数据库中获取信息。
            FormMain.LoadNewControl(Modify.Instance); // 载入该模块的修改信息界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“删除”按钮时的事件处理方法。
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete.LoadDataById(employee.Id.ToString()); // 根据关联对象的主键，从数据库中获取信息。
            FormMain.LoadNewControl(Delete.Instance);  // 载入该模块的删除信息界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“返回”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormMain.LoadNewControl(Default.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }


        #region 界面控件与关联对象之间的绑定方法

        /// <summary>
        /// 将关联对象中的值，绑定至界面控件进行显示。
        /// </summary>
        private void BindObjectToForm()
        {
            LblBadgeId.Text = employee.BadgeId;  // 工号
            LblName.Text = employee.Name;  // 姓名
            LblSex.Text = (employee.Sex != null) ? employee.Sex.Name : null;  // 性别
            LblDateOfBirth.Text = employee.DateOfBirth.HasValue ? employee.DateOfBirth.Value.ToString("yyyy-MM-dd") : null;  // 出生日期
            LblIDCardId.Text = employee.IDCardId;  // 身份证号
            LblNationa.Text = employee.Nationa;  // 民族
            LblPoliticalLandscape.Text = employee.PoliticalLandscape;  // 政治面貌
            LblMaritalStatus.Text = employee.MaritalStatus;  // 婚姻状况
            LblPlaceOfHouseholdRegistration.Text = employee.PlaceOfHouseholdRegistration;  // 户口所在地
            LblDepartment.Text = (employee.Department != null) ? employee.Department.DepartmentName : null;  // 所在部门
            LblResidenceAddress.Text = employee.ResidenceAddress;  // 现居住住址
            LblGraduateSchool.Text = employee.GraduateSchool;  // 毕业学校
            LblFieldOfStudy.Text = employee.FieldOfStudy;  // 所学专业
            LblGraduationDate.Text = employee.GraduationDate;  // 毕业时间
            LblAcademicQualifications.Text = employee.AcademicQualifications;  // 学历
            LblContactPhone.Text = employee.ContactPhone;  // 联系电话
            LblEmergencyContacts.Text = employee.EmergencyContacts;  // 紧急联系人
            LblEmergencyTelephone.Text = employee.EmergencyTelephone;  // 紧急电话
        }

        #endregion 界面控件与关联对象之间的绑定方法


    }
}
