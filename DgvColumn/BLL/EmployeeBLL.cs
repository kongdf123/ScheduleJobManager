using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using BudStudio.DgvColumn.COL;
using BudStudio.DgvColumn.DAL;
using BudStudio.DgvColumn.SFL;

namespace BudStudio.DgvColumn.BLL
{
    /// <summary>
    /// 对象名称：员工信息业务逻辑类（业务逻辑层）
    /// 对象说明：该类的功能描述与摘要说明。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012-2-29 16:07:21
    /// </summary>
    public class EmployeeBLL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要提供该类的基本业务逻辑。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 返回与本类相关联的数据访问类。通常本类需要访问自身关联的数据访问类，与数据库进行交互时，应优先使用该属性，
        /// 本类调用业务逻辑层其它业务逻辑类时，应当优先使用其它类中公开的方法，而不优先使用其它类中的DataAccess属性。
        /// </summary>
        internal static DAL.Common.EmployeeDAL DataAccess
        {
            get
            {
                return DAL.Common.EmployeeDAL.Instance;
            }
        }


        /// <summary>
        /// 对员工信息（Employee）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        public static void CheckValid(Employee employee)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(employee.BadgeId))
                throw new CustomException("“工号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(employee.Name))
                throw new CustomException("“姓名”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(employee.Sex))
                throw new CustomException("“性别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(employee.DateOfBirth))
                throw new CustomException("“出生日期”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(employee.IDCardId))
                throw new CustomException("“身份证号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(employee.Department))
                throw new CustomException("“所在部门”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(employee.GraduateSchool))
                throw new CustomException("“毕业学校”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(employee.AcademicQualifications))
                throw new CustomException("“学历”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(employee.ContactPhone))
                throw new CustomException("“联系电话”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(employee.BadgeId , 50))
                throw new CustomException("“工号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.Name , 50))
                throw new CustomException("“姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.IDCardId , 50))
                throw new CustomException("“身份证号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.Nationa , 50))
                throw new CustomException("“民族”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.PoliticalLandscape , 50))
                throw new CustomException("“政治面貌”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.MaritalStatus , 50))
                throw new CustomException("“婚姻状况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.PlaceOfHouseholdRegistration , 50))
                throw new CustomException("“户口所在地”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.ResidenceAddress , 50))
                throw new CustomException("“现居住住址”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.GraduateSchool , 50))
                throw new CustomException("“毕业学校”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.FieldOfStudy , 50))
                throw new CustomException("“所学专业”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.GraduationDate , 50))
                throw new CustomException("“毕业时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.AcademicQualifications , 50))
                throw new CustomException("“学历”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.ContactPhone , 50))
                throw new CustomException("“联系电话”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.EmergencyContacts , 50))
                throw new CustomException("“紧急联系人”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(employee.EmergencyTelephone , 50))
                throw new CustomException("“紧急电话”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将员工信息（Employee）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        public static int Insert(Employee employee)
        {
            CheckValid(employee);
            return DataAccess.Insert(employee);
        }


        /// <summary>
        /// 将员工信息（Employee）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        public static int Update(Employee employee)
        {
            CheckValid(employee);
            return DataAccess.Update(employee);
        }


        /// <summary>
        /// 根据员工信息（Employee）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">员工信息（Employee）的主键“自动编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据员工信息（Employee）的主键“自动编号（Id）”从数据库中获取员工信息（Employee）的实例。
        /// 成功从数据库中取得记录返回新员工信息（Employee）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">员工信息（Employee）的主键“自动编号（Id）”</param>
        public static Employee GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据员工信息（Employee）的主键“自动编号（Id）”从数据库中获取员工信息（Employee）的实例。
        /// 成功从数据库中取得记录返回新员工信息（Employee）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">员工信息（Employee）的主键“自动编号（Id）”</param>
        public static Employee GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// 从数据库中读取并返回所有员工信息（Employee）List列表。
        /// </summary>
        public static List<Employee> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的员工信息（Employee）的列表及分页信息。
        /// 该方法所获取的员工信息（Employee）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public static PageData GetPageList(int pageSize, int curPage)
        {
            return DataAccess.GetPageList(pageSize,curPage);
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
