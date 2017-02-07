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
    /// 对象名称：员工信息OleDb数据访问子类（数据访问层）
    /// 对象说明：提供“员工信息类（业务逻辑层）”针对OleDb的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“员工信息类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：爱英思躺
    /// 编写日期：2012-2-29 16:07:21
    /// </summary>
    public class EmployeeDAL:DAL.Common.EmployeeDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将员工信息（Employee）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        public override int Insert(Employee employee)
        {
            string sqlText = "INSERT INTO [Employee]"
                           + "([BadgeId],[Name],[SexId],[DateOfBirth],[IDCardId],[Nationa],[PoliticalLandscape],[MaritalStatus],[PlaceOfHouseholdRegistration],"
                           + "[DepartmentId],[ResidenceAddress],[GraduateSchool],[FieldOfStudy],[GraduationDate],[AcademicQualifications],[ContactPhone],[EmergencyContacts],"
                           + "[EmergencyTelephone])"
                           + "VALUES"
                           + "(@BadgeId,@Name,@SexId,@DateOfBirth,@IDCardId,@Nationa,@PoliticalLandscape,@MaritalStatus,@PlaceOfHouseholdRegistration,"
                           + "@DepartmentId,@ResidenceAddress,@GraduateSchool,@FieldOfStudy,@GraduationDate,@AcademicQualifications,@ContactPhone,@EmergencyContacts,"
                           + "@EmergencyTelephone)";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@BadgeId"                      , OleDbType.VarWChar , 50){ Value = employee.BadgeId                      },
                new OleDbParameter("@Name"                         , OleDbType.VarWChar , 50){ Value = employee.Name                         },
                new OleDbParameter("@SexId"                        , OleDbType.Integer  , 4 ){ Value = employee.Sex.Id                       },
                new OleDbParameter("@DateOfBirth"                  , OleDbType.Date     , 8 ){ Value = employee.DateOfBirth                  },
                new OleDbParameter("@IDCardId"                     , OleDbType.VarWChar , 50){ Value = employee.IDCardId                     },
                new OleDbParameter("@Nationa"                      , OleDbType.VarWChar , 50){ Value = employee.Nationa                      },
                new OleDbParameter("@PoliticalLandscape"           , OleDbType.VarWChar , 50){ Value = employee.PoliticalLandscape           },
                new OleDbParameter("@MaritalStatus"                , OleDbType.VarWChar , 50){ Value = employee.MaritalStatus                },
                new OleDbParameter("@PlaceOfHouseholdRegistration" , OleDbType.VarWChar , 50){ Value = employee.PlaceOfHouseholdRegistration },
                new OleDbParameter("@DepartmentId"                 , OleDbType.Integer  , 4 ){ Value = employee.Department.Id                },
                new OleDbParameter("@ResidenceAddress"             , OleDbType.VarWChar , 50){ Value = employee.ResidenceAddress             },
                new OleDbParameter("@GraduateSchool"               , OleDbType.VarWChar , 50){ Value = employee.GraduateSchool               },
                new OleDbParameter("@FieldOfStudy"                 , OleDbType.VarWChar , 50){ Value = employee.FieldOfStudy                 },
                new OleDbParameter("@GraduationDate"               , OleDbType.VarWChar , 50){ Value = employee.GraduationDate               },
                new OleDbParameter("@AcademicQualifications"       , OleDbType.VarWChar , 50){ Value = employee.AcademicQualifications       },
                new OleDbParameter("@ContactPhone"                 , OleDbType.VarWChar , 50){ Value = employee.ContactPhone                 },
                new OleDbParameter("@EmergencyContacts"            , OleDbType.VarWChar , 50){ Value = employee.EmergencyContacts            },
                new OleDbParameter("@EmergencyTelephone"           , OleDbType.VarWChar , 50){ Value = employee.EmergencyTelephone           }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将员工信息（Employee）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="employee">员工信息（Employee）实例对象</param>
        public override int Update(Employee employee)
        {
            string sqlText = "UPDATE [Employee] SET "
                           + "[BadgeId]=@BadgeId,[Name]=@Name,[SexId]=@SexId,[DateOfBirth]=@DateOfBirth,[IDCardId]=@IDCardId,[Nationa]=@Nationa,"
                           + "[PoliticalLandscape]=@PoliticalLandscape,[MaritalStatus]=@MaritalStatus,[PlaceOfHouseholdRegistration]=@PlaceOfHouseholdRegistration,[DepartmentId]=@DepartmentId,"
                           + "[ResidenceAddress]=@ResidenceAddress,[GraduateSchool]=@GraduateSchool,[FieldOfStudy]=@FieldOfStudy,[GraduationDate]=@GraduationDate,"
                           + "[AcademicQualifications]=@AcademicQualifications,[ContactPhone]=@ContactPhone,[EmergencyContacts]=@EmergencyContacts,[EmergencyTelephone]=@EmergencyTelephone "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@BadgeId"                      , OleDbType.VarWChar , 50){ Value = employee.BadgeId                      },
                new OleDbParameter("@Name"                         , OleDbType.VarWChar , 50){ Value = employee.Name                         },
                new OleDbParameter("@SexId"                        , OleDbType.Integer  , 4 ){ Value = employee.Sex.Id                       },
                new OleDbParameter("@DateOfBirth"                  , OleDbType.Date     , 8 ){ Value = employee.DateOfBirth                  },
                new OleDbParameter("@IDCardId"                     , OleDbType.VarWChar , 50){ Value = employee.IDCardId                     },
                new OleDbParameter("@Nationa"                      , OleDbType.VarWChar , 50){ Value = employee.Nationa                      },
                new OleDbParameter("@PoliticalLandscape"           , OleDbType.VarWChar , 50){ Value = employee.PoliticalLandscape           },
                new OleDbParameter("@MaritalStatus"                , OleDbType.VarWChar , 50){ Value = employee.MaritalStatus                },
                new OleDbParameter("@PlaceOfHouseholdRegistration" , OleDbType.VarWChar , 50){ Value = employee.PlaceOfHouseholdRegistration },
                new OleDbParameter("@DepartmentId"                 , OleDbType.Integer  , 4 ){ Value = employee.Department.Id                },
                new OleDbParameter("@ResidenceAddress"             , OleDbType.VarWChar , 50){ Value = employee.ResidenceAddress             },
                new OleDbParameter("@GraduateSchool"               , OleDbType.VarWChar , 50){ Value = employee.GraduateSchool               },
                new OleDbParameter("@FieldOfStudy"                 , OleDbType.VarWChar , 50){ Value = employee.FieldOfStudy                 },
                new OleDbParameter("@GraduationDate"               , OleDbType.VarWChar , 50){ Value = employee.GraduationDate               },
                new OleDbParameter("@AcademicQualifications"       , OleDbType.VarWChar , 50){ Value = employee.AcademicQualifications       },
                new OleDbParameter("@ContactPhone"                 , OleDbType.VarWChar , 50){ Value = employee.ContactPhone                 },
                new OleDbParameter("@EmergencyContacts"            , OleDbType.VarWChar , 50){ Value = employee.EmergencyContacts            },
                new OleDbParameter("@EmergencyTelephone"           , OleDbType.VarWChar , 50){ Value = employee.EmergencyTelephone           },
                new OleDbParameter("@Id"                           , OleDbType.Integer  , 4 ){ Value = employee.Id                           }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据员工信息（Employee）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">员工信息（Employee）的主键“自动编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Employee] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据员工信息（Employee）的主键“自动编号（Id）”从数据库中获取员工信息（Employee）的实例。
        /// 成功从数据库中取得记录返回新员工信息（Employee）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">员工信息（Employee）的主键“自动编号（Id）”</param>
        public override Employee GetDataById(int id)
        {
            Employee employee = null;
            string sqlText = "SELECT [Id],[BadgeId],[Name],[SexId],[DateOfBirth],[IDCardId],[Nationa],[PoliticalLandscape],[MaritalStatus],[PlaceOfHouseholdRegistration],"
                           + "[DepartmentId],[ResidenceAddress],[GraduateSchool],[FieldOfStudy],[GraduationDate],[AcademicQualifications],[ContactPhone],[EmergencyContacts],"
                           + "[EmergencyTelephone] "
                           + "FROM [Employee] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                employee = new Employee();
                ReadEmployeeAllData(oleDbDataReader,employee);
            }
            oleDbDataReader.Close();
            return employee;
        }


        /// <summary>
        /// 从数据库中读取并返回所有员工信息（Employee）List列表。
        /// </summary>
        public override List<Employee> GetAllList()
        {
            string sqlText = "SELECT [Id],[BadgeId],[Name],[SexId],[DateOfBirth],[IDCardId],[Nationa],[PoliticalLandscape],[MaritalStatus],[PlaceOfHouseholdRegistration],"
                           + "[DepartmentId],[ResidenceAddress],[GraduateSchool],[FieldOfStudy],[GraduationDate],[AcademicQualifications],[ContactPhone],[EmergencyContacts],"
                           + "[EmergencyTelephone] "
                           + "FROM [Employee]";
            List<Employee> list = new List<Employee>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                Employee employee = new Employee();
                ReadEmployeeAllData(oleDbDataReader, employee);
                list.Add(employee);
            }
            oleDbDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的员工信息（Employee）的列表及分页信息。
        /// 该方法所获取的员工信息（Employee）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[BadgeId],[Name],[SexId],[GraduateSchool],[ContactPhone] "
                           + "FROM [Employee]";
            List<Employee> list = new List<Employee>();
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
                    Employee employee = new Employee();
                    ReadEmployeePageData(oleDbDataReader, employee);
                    list.Add(employee);
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
