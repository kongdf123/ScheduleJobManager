using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Collections.Generic;
using BudStudio.DgvColumn.COL;
using BudStudio.DgvColumn.SFL;

namespace BudStudio.DgvColumn.DAL.OleDb
{
    /// <summary>
    /// 对象名称：部门信息OleDb数据访问子类（数据访问层）
    /// 对象说明：提供“部门信息类（业务逻辑层）”针对OleDb的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“部门信息类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012-2-29 16:07:21
    /// </summary>
    public class DepartmentDAL:DAL.Common.DepartmentDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将部门信息（Department）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="department">部门信息（Department）实例对象</param>
        public override int Insert(Department department)
        {
            string sqlText = "INSERT INTO [Department]"
                           + "([DepartmentName],[ManagerName],[ContactPhone],[NoteDescription])"
                           + "VALUES"
                           + "(@DepartmentName,@ManagerName,@ContactPhone,@NoteDescription)";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@DepartmentName"  , OleDbType.VarWChar     , 50        ){ Value = department.DepartmentName  },
                new OleDbParameter("@ManagerName"     , OleDbType.VarWChar     , 50        ){ Value = department.ManagerName     },
                new OleDbParameter("@ContactPhone"    , OleDbType.VarWChar     , 50        ){ Value = department.ContactPhone    },
                new OleDbParameter("@NoteDescription" , OleDbType.LongVarWChar , 1073741823){ Value = department.NoteDescription }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将部门信息（Department）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="department">部门信息（Department）实例对象</param>
        public override int Update(Department department)
        {
            string sqlText = "UPDATE [Department] SET "
                           + "[DepartmentName]=@DepartmentName,[ManagerName]=@ManagerName,[ContactPhone]=@ContactPhone,[NoteDescription]=@NoteDescription "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@DepartmentName"  , OleDbType.VarWChar     , 50        ){ Value = department.DepartmentName  },
                new OleDbParameter("@ManagerName"     , OleDbType.VarWChar     , 50        ){ Value = department.ManagerName     },
                new OleDbParameter("@ContactPhone"    , OleDbType.VarWChar     , 50        ){ Value = department.ContactPhone    },
                new OleDbParameter("@NoteDescription" , OleDbType.LongVarWChar , 1073741823){ Value = department.NoteDescription },
                new OleDbParameter("@Id"              , OleDbType.Integer      , 4         ){ Value = department.Id              }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据部门信息（Department）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">部门信息（Department）的主键“自动编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Department] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据部门信息（Department）的主键“自动编号（Id）”从数据库中获取部门信息（Department）的实例。
        /// 成功从数据库中取得记录返回新部门信息（Department）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">部门信息（Department）的主键“自动编号（Id）”</param>
        public override Department GetDataById(int id)
        {
            Department department = null;
            string sqlText = "SELECT [Id],[DepartmentName],[ManagerName],[ContactPhone],[NoteDescription] "
                           + "FROM [Department] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                department = new Department();
                ReadDepartmentAllData(oleDbDataReader,department);
            }
            oleDbDataReader.Close();
            return department;
        }


        /// <summary>
        /// 从数据库中读取并返回所有部门信息（Department）List列表。
        /// </summary>
        public override List<Department> GetAllList()
        {
            string sqlText = "SELECT [Id],[DepartmentName],[ManagerName],[ContactPhone],[NoteDescription] "
                           + "FROM [Department]";
            List<Department> list = new List<Department>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                Department department = new Department();
                ReadDepartmentAllData(oleDbDataReader, department);
                list.Add(department);
            }
            oleDbDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的部门信息（Department）的列表及分页信息。
        /// 该方法所获取的部门信息（Department）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[DepartmentName],[ManagerName],[ContactPhone] "
                           + "FROM [Department]";
            List<Department> list = new List<Department>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);

            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = 0;
            pageData.PageCount = 1;

            int first = (curPage - 1) * pageSize + 1;
            int last = curPage * pageSize;

            while (oleDbDataReader.Read())
            {
                pageData.RecordCount++;
                if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                {
                    Department department = new Department();
                    ReadDepartmentPageData(oleDbDataReader, department);
                    list.Add(department);
                }
            }
            oleDbDataReader.Close();

            if(pageData.RecordCount>0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));

            pageData.PageList = list;
            return pageData;
        }

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
