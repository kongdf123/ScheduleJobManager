using DataAccess.DAL;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            //TODO
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
