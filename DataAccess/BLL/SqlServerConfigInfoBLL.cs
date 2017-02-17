using DataAccess.DAL;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace DataAccess.BLL
{
    public class SqlServerConfigInfoBLL
    {
        SqlServerConfigInfoDAL _dal;

        public SqlServerConfigInfoBLL() {
            _dal = new SqlServerConfigInfoDAL();
        }

        public static SqlServerConfigInfoBLL CreateInstance()
        {
            return new SqlServerConfigInfoBLL();
        }

        public void CheckValid(SqlServerConfigInfo dbConfigInfo)
        {
            if (string.IsNullOrEmpty(dbConfigInfo.EquipmentNum))
            {
                throw new CustomException("请输入设备编号", ExceptionType.Warn);
            }

            if (string.IsNullOrEmpty(dbConfigInfo.ServerAddress))
            {
                throw new CustomException("请输入数据库服务器地址", ExceptionType.Warn);
            }

            if (string.IsNullOrEmpty(dbConfigInfo.DBName))
            {
                throw new CustomException("请输入数据库名称", ExceptionType.Warn);
            }

            if (string.IsNullOrEmpty(dbConfigInfo.UserName))
            {
                throw new CustomException("请输入数据库登录名", ExceptionType.Warn);
            }

            if (string.IsNullOrEmpty(dbConfigInfo.Password))
            {
                throw new CustomException("请输入数据库登录密码", ExceptionType.Warn);
            }
        }

        public int Insert(SqlServerConfigInfo dbConfigInfo)
        {
            CheckValid(dbConfigInfo);
            return _dal.Insert(dbConfigInfo);
        }

        public int Update(SqlServerConfigInfo dbConfigInfo)
        {
            CheckValid(dbConfigInfo);
            return _dal.Update(dbConfigInfo);
        }

        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        public SqlServerConfigInfo Get(int id)
        {
            return _dal.Get(id);
        }

        public List<SqlServerConfigInfo> GetAll() {
            List<SqlServerConfigInfo> listSqlServerConfig = new List<SqlServerConfigInfo>();
            PageData pageData =GetPageList(200, 1);
            if (pageData.PageList != null)
            {
                listSqlServerConfig.AddRange(pageData.PageList.Cast<SqlServerConfigInfo>());
            }

            if (pageData.PageCount > 0)
            {
                for (int i = 2; i <= pageData.PageCount; i++)
                {
                    listSqlServerConfig.AddRange(GetPageList(200, i).PageList.Cast<SqlServerConfigInfo>());
                }
            }
            return listSqlServerConfig;
        }

        public PageData GetPageList(int pageSize, int curPage, string dbName = "")
        {
            return _dal.GetPageList(pageSize, curPage, dbName);
        }
    }
}
