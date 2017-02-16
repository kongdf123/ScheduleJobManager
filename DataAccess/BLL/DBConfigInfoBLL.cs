using DataAccess.DAL;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace DataAccess.BLL
{
    public class DBConfigInfoBLL
    {
        public static DBConfigInfoBLL CreateInstance()
        {
            return new DBConfigInfoBLL();
        }

        public void CheckValid(DBConfigInfo dbConfigInfo)
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

        public int Insert(DBConfigInfo dbConfigInfo)
        {
            CheckValid(dbConfigInfo);
            return DBConfigInfoDAL.CreateInstance().Insert(dbConfigInfo);
        }

        public int Update(DBConfigInfo dbConfigInfo)
        {
            CheckValid(dbConfigInfo);
            return DBConfigInfoDAL.CreateInstance().Update(dbConfigInfo);
        }

        public int Delete(int id)
        {
            return DBConfigInfoDAL.CreateInstance().Delete(id);
        }

        public DBConfigInfo Get(int id)
        {
            return DBConfigInfoDAL.CreateInstance().Get(id);
        }

        public PageData GetPageList(int pageSize, int curPage, string dbName = "")
        {
            return DBConfigInfoDAL.CreateInstance().GetPageList(pageSize, curPage, dbName);
        }
    }
}
