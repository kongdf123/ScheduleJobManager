using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using BudStudio.DgvColumn.COL;
using BudStudio.DgvColumn.SFL;

namespace BudStudio.DgvColumn.DAL.Common
{
    /// <summary>
    /// 对象名称：员工信息通用数据访问父类（数据访问层）
    /// 对象说明：提供“员工信息类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“员工信息类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012-2-29 16:07:21
    /// </summary>
    public abstract class EmployeeDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“员工信息（EmployeeDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static EmployeeDAL employeeDAL;


        /// <summary>
        /// 获取“员工信息（EmployeeDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“员工信息（EmployeeDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static EmployeeDAL Instance
        {
            get
            {
                if (employeeDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            employeeDAL = new SqlServer.EmployeeDAL();
                            break;

                        case "OleDb":
                            employeeDAL = new OleDb.EmployeeDAL();
                            break;

                        default:
                            employeeDAL = new SqlServer.EmployeeDAL();
                            break;
                    }
                }
                return employeeDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Employee对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        protected void ReadEmployeeAllData(IDataReader dataReader, Employee employee)
        {
            // 自动编号
            if (dataReader["Id"] != DBNull.Value)
                employee.Id = Convert.ToInt32(dataReader["Id"]);
            // 工号
            if (dataReader["BadgeId"] != DBNull.Value)
                employee.BadgeId = Convert.ToString(dataReader["BadgeId"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                employee.Name = Convert.ToString(dataReader["Name"]);
            // 性别
            if (dataReader["SexId"] != DBNull.Value)
            {
                Sex tmpSex = Sex.GetDataById(Convert.ToInt32(dataReader["SexId"]));
                if (tmpSex != null) employee.Sex = tmpSex;
            }
            // 出生日期
            if (dataReader["DateOfBirth"] != DBNull.Value)
                employee.DateOfBirth = Convert.ToDateTime(dataReader["DateOfBirth"]);
            // 身份证号
            if (dataReader["IDCardId"] != DBNull.Value)
                employee.IDCardId = Convert.ToString(dataReader["IDCardId"]);
            // 民族
            if (dataReader["Nationa"] != DBNull.Value)
                employee.Nationa = Convert.ToString(dataReader["Nationa"]);
            // 政治面貌
            if (dataReader["PoliticalLandscape"] != DBNull.Value)
                employee.PoliticalLandscape = Convert.ToString(dataReader["PoliticalLandscape"]);
            // 婚姻状况
            if (dataReader["MaritalStatus"] != DBNull.Value)
                employee.MaritalStatus = Convert.ToString(dataReader["MaritalStatus"]);
            // 户口所在地
            if (dataReader["PlaceOfHouseholdRegistration"] != DBNull.Value)
                employee.PlaceOfHouseholdRegistration = Convert.ToString(dataReader["PlaceOfHouseholdRegistration"]);
            // 所在部门
            if (dataReader["DepartmentId"] != DBNull.Value)
            {
                Department tmpDepartment = DepartmentDAL.Instance.GetDataById(Convert.ToInt32(dataReader["DepartmentId"]));
                if (tmpDepartment != null) employee.Department = tmpDepartment;
            }
            // 现居住住址
            if (dataReader["ResidenceAddress"] != DBNull.Value)
                employee.ResidenceAddress = Convert.ToString(dataReader["ResidenceAddress"]);
            // 毕业学校
            if (dataReader["GraduateSchool"] != DBNull.Value)
                employee.GraduateSchool = Convert.ToString(dataReader["GraduateSchool"]);
            // 所学专业
            if (dataReader["FieldOfStudy"] != DBNull.Value)
                employee.FieldOfStudy = Convert.ToString(dataReader["FieldOfStudy"]);
            // 毕业时间
            if (dataReader["GraduationDate"] != DBNull.Value)
                employee.GraduationDate = Convert.ToString(dataReader["GraduationDate"]);
            // 学历
            if (dataReader["AcademicQualifications"] != DBNull.Value)
                employee.AcademicQualifications = Convert.ToString(dataReader["AcademicQualifications"]);
            // 联系电话
            if (dataReader["ContactPhone"] != DBNull.Value)
                employee.ContactPhone = Convert.ToString(dataReader["ContactPhone"]);
            // 紧急联系人
            if (dataReader["EmergencyContacts"] != DBNull.Value)
                employee.EmergencyContacts = Convert.ToString(dataReader["EmergencyContacts"]);
            // 紧急电话
            if (dataReader["EmergencyTelephone"] != DBNull.Value)
                employee.EmergencyTelephone = Convert.ToString(dataReader["EmergencyTelephone"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Employee对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        protected void ReadEmployeePageData(IDataReader dataReader, Employee employee)
        {
            // 自动编号
            if (dataReader["Id"] != DBNull.Value)
                employee.Id = Convert.ToInt32(dataReader["Id"]);
            // 工号
            if (dataReader["BadgeId"] != DBNull.Value)
                employee.BadgeId = Convert.ToString(dataReader["BadgeId"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                employee.Name = Convert.ToString(dataReader["Name"]);
            // 性别
            if (dataReader["SexId"] != DBNull.Value)
            {
                Sex tmpSex = Sex.GetDataById(Convert.ToInt32(dataReader["SexId"]));
                if (tmpSex != null) employee.Sex = tmpSex;
            }
            // 毕业学校
            if (dataReader["GraduateSchool"] != DBNull.Value)
                employee.GraduateSchool = Convert.ToString(dataReader["GraduateSchool"]);
            // 联系电话
            if (dataReader["ContactPhone"] != DBNull.Value)
                employee.ContactPhone = Convert.ToString(dataReader["ContactPhone"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将员工信息（Employee）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        public abstract int Insert(Employee employee);


        /// <summary>
        /// 将员工信息（Employee）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        public abstract int Update(Employee employee);


        /// <summary>
        /// 根据员工信息（Employee）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">员工信息（Employee）的主键“自动编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据员工信息（Employee）的主键“自动编号（Id）”从数据库中获取员工信息（Employee）的实例。
        /// 成功从数据库中取得记录返回新员工信息（Employee）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">员工信息（Employee）的主键“自动编号（Id）”</param>
        public abstract Employee GetDataById(int id);


        /// <summary>
        /// 从数据库中读取并返回所有员工信息（Employee）List列表。
        /// </summary>
        public abstract List<Employee> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的员工信息（Employee）的列表及分页信息。
        /// 该方法所获取的员工信息（Employee）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
