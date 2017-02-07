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
    /// 对象名称：部门信息通用数据访问父类（数据访问层）
    /// 对象说明：提供“部门信息类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“部门信息类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012-2-29 16:07:21
    /// </summary>
    public abstract class DepartmentDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“部门信息（DepartmentDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static DepartmentDAL departmentDAL;


        /// <summary>
        /// 获取“部门信息（DepartmentDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“部门信息（DepartmentDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static DepartmentDAL Instance
        {
            get
            {
                if (departmentDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            departmentDAL = new SqlServer.DepartmentDAL();
                            break;

                        case "OleDb":
                            departmentDAL = new OleDb.DepartmentDAL();
                            break;

                        default:
                            departmentDAL = new SqlServer.DepartmentDAL();
                            break;
                    }
                }
                return departmentDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Department对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="department">部门信息（Department）实例对象</param>
        protected void ReadDepartmentAllData(IDataReader dataReader, Department department)
        {
            // 自动编号
            if (dataReader["Id"] != DBNull.Value)
                department.Id = Convert.ToInt32(dataReader["Id"]);
            // 部门名称
            if (dataReader["DepartmentName"] != DBNull.Value)
                department.DepartmentName = Convert.ToString(dataReader["DepartmentName"]);
            // 经理姓名
            if (dataReader["ManagerName"] != DBNull.Value)
                department.ManagerName = Convert.ToString(dataReader["ManagerName"]);
            // 联系电话
            if (dataReader["ContactPhone"] != DBNull.Value)
                department.ContactPhone = Convert.ToString(dataReader["ContactPhone"]);
            // 备注说明
            if (dataReader["NoteDescription"] != DBNull.Value)
                department.NoteDescription = Convert.ToString(dataReader["NoteDescription"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Department对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="department">部门信息（Department）实例对象</param>
        protected void ReadDepartmentPageData(IDataReader dataReader, Department department)
        {
            // 自动编号
            if (dataReader["Id"] != DBNull.Value)
                department.Id = Convert.ToInt32(dataReader["Id"]);
            // 部门名称
            if (dataReader["DepartmentName"] != DBNull.Value)
                department.DepartmentName = Convert.ToString(dataReader["DepartmentName"]);
            // 经理姓名
            if (dataReader["ManagerName"] != DBNull.Value)
                department.ManagerName = Convert.ToString(dataReader["ManagerName"]);
            // 联系电话
            if (dataReader["ContactPhone"] != DBNull.Value)
                department.ContactPhone = Convert.ToString(dataReader["ContactPhone"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将部门信息（Department）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="department">部门信息（Department）实例对象</param>
        public abstract int Insert(Department department);


        /// <summary>
        /// 将部门信息（Department）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="department">部门信息（Department）实例对象</param>
        public abstract int Update(Department department);


        /// <summary>
        /// 根据部门信息（Department）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">部门信息（Department）的主键“自动编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据部门信息（Department）的主键“自动编号（Id）”从数据库中获取部门信息（Department）的实例。
        /// 成功从数据库中取得记录返回新部门信息（Department）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">部门信息（Department）的主键“自动编号（Id）”</param>
        public abstract Department GetDataById(int id);


        /// <summary>
        /// 从数据库中读取并返回所有部门信息（Department）List列表。
        /// </summary>
        public abstract List<Department> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的部门信息（Department）的列表及分页信息。
        /// 该方法所获取的部门信息（Department）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
