using DataAccess.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccess.DAL
{
    public class DBConfigInfoDAL
    {
        public static DBConfigInfoDAL CreateInstance()
        {
            return new DBConfigInfoDAL();
        }

        public int Insert(DBConfigInfo dbConfigInfo)
        {
            dbConfigInfo.UpdatedDate = DateTime.Now;
            dbConfigInfo.CreatedDate = DateTime.Now;

            string sqlText = @"INSERT INTO `custom_db_config`
                                (`Id`,
                                `ServerIP`,
                                `DBName`,
                                `UserName`,
                                `Password`,
                                `UpdatedDate`,
                                `CreatedDate`)
                                VALUES
                                (@Id,
                                @ServerIP,
                                @DBName,
                                @UserName,
                                @Password,
                                @UpdatedDate,
                                @CreatedDate); SELECT LAST_INSERT_ID();";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Id", MySqlDbType.Int32 ){ Value = dbConfigInfo.Id },
                new MySqlParameter("@DBName", MySqlDbType.VarChar , 45 ){ Value = dbConfigInfo.DBName },
                new MySqlParameter("@ServerIP", MySqlDbType.VarChar , 30 ){ Value = dbConfigInfo.ServerIP },
                new MySqlParameter("@UserName", MySqlDbType.VarChar , 45){ Value = dbConfigInfo.UserName},
                new MySqlParameter("@Password", MySqlDbType.VarChar, 45){ Value = dbConfigInfo.Password},
                new MySqlParameter("@UpdatedDate" , MySqlDbType.DateTime){ Value = dbConfigInfo.UpdatedDate },
                new MySqlParameter("@CreatedDate", MySqlDbType.DateTime){ Value = dbConfigInfo.CreatedDate}
            };
            return MySqlDBHelper.ExecuteScalar<int>(sqlText, parameters);
        }

        public int Update(DBConfigInfo dbConfigInfo)
        {
            dbConfigInfo.UpdatedDate = DateTime.Now;
            string sqlText = @"UPDATE `custom_db_config`
                                SET
                                `ServerIP` = @ServerIP,
                                `DBName` = @DBName,
                                `UserName` = @UserName,
                                `Password` = @Password,
                                `UpdatedDate` = @UpdatedDate,
                                `CreatedDate` = @CreatedDate
                                WHERE `Id` = @Id;";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Id", MySqlDbType.Int32 ){ Value = dbConfigInfo.Id },
                new MySqlParameter("@DBName", MySqlDbType.VarChar , 45 ){ Value = dbConfigInfo.DBName },
                new MySqlParameter("@ServerIP", MySqlDbType.VarChar , 30 ){ Value = dbConfigInfo.ServerIP },
                new MySqlParameter("@UserName", MySqlDbType.VarChar , 45){ Value = dbConfigInfo.UserName},
                new MySqlParameter("@Password", MySqlDbType.VarChar, 45){ Value = dbConfigInfo.Password},
                new MySqlParameter("@UpdatedDate" , MySqlDbType.DateTime){ Value = dbConfigInfo.UpdatedDate },
                new MySqlParameter("@CreatedDate", MySqlDbType.DateTime){ Value = dbConfigInfo.CreatedDate}
            };
            return MySqlDBHelper.ExecuteNonQuery(sqlText, parameters);
        }

        public int Delete(int id)
        {
            string sqlText = "DELETE FROM `custom_db_config` WHERE `Id` = @Id;";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Id" , MySqlDbType.Int32){ Value = id }
            };
            return MySqlDBHelper.ExecuteNonQuery(sqlText, parameters);
        }

        public DBConfigInfo Get(int id)
        {
            DBConfigInfo dbConfigInfo = null;
            string sqlText = @" SELECT `Id`,
                                    `ServerIP`,
                                    `DBName`,
                                    `UserName`,
                                    `Password`,
                                    `UpdatedDate`,
                                    `CreatedDate`
                                FROM `custom_db_config` 
                                WHERE `Id` = @Id;";
            MySqlParameter[] parameters =
            {
                 new MySqlParameter("@Id" , MySqlDbType.Int32){ Value = id }
            };

            MySqlDataReader sqlDataReader = MySqlDBHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                dbConfigInfo = new DBConfigInfo();
                ReadRecordData(sqlDataReader, dbConfigInfo);
            }
            sqlDataReader.Close();
            return dbConfigInfo;
        }

        public PageData GetPageList(int pageSize, int curPage, string dbName = "")
        {
            string sqlWhere = "";
            List<MySqlParameter> listParms = new List<MySqlParameter>();
            if (!string.IsNullOrEmpty(dbName))
            {
                sqlWhere = "WHERE `DBName` LIKE @DBName";
                listParms.Add(new MySqlParameter("@DBName", MySqlDbType.VarChar, 45) { Value = "%" + dbName + "%" });
            }

            int recordsTotal = MySqlDBHelper.ExecuteScalar<int>("SELECT COUNT(*) FROM custom_db_config " + sqlWhere, listParms.ToArray());

            string sqlText = @" SELECT `Id`,
                                    `ServerIP`,
                                    `DBName`,
                                    `UserName`,
                                    `Password`,
                                    `UpdatedDate`,
                                    `CreatedDate`
                                FROM `custom_db_config`  " + sqlWhere + " ORDER BY Id DESC LIMIT " + (curPage - 1)* pageSize + "," + pageSize;
            List<DBConfigInfo> list = new List<DBConfigInfo>();
            MySqlDataReader sqlDataReader = MySqlDBHelper.ExecuteReader(sqlText, listParms.ToArray());

            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = Math.Max(1, recordsTotal);
            if (pageData.RecordCount > 0)
            {
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));
            }

            while (sqlDataReader.Read())
            {
                DBConfigInfo dbConfigInfo = new DBConfigInfo();
                ReadRecordData(sqlDataReader, dbConfigInfo);
                list.Add(dbConfigInfo);
            }
            sqlDataReader.Close();
            pageData.PageList = list;
            return pageData;
        }

        void ReadRecordData(IDataReader dataReader, DBConfigInfo dbConfigInfo)
        {
            if (dataReader["Id"] != DBNull.Value)
                dbConfigInfo.Id = Convert.ToInt32(dataReader["Id"]);

            if (dataReader["ServerIP"] != DBNull.Value)
                dbConfigInfo.ServerIP = Convert.ToString(dataReader["ServerIP"]);

            if (dataReader["DBName"] != DBNull.Value)
                dbConfigInfo.DBName = Convert.ToString(dataReader["DBName"]);

            if (dataReader["UserName"] != DBNull.Value)
                dbConfigInfo.UserName = Convert.ToString(dataReader["UserName"]);

            if (dataReader["Password"] != DBNull.Value)
                dbConfigInfo.Password = Convert.ToString(dataReader["Password"]);

            if (dataReader["UpdatedDate"] != DBNull.Value)
                dbConfigInfo.UpdatedDate = Convert.ToDateTime(dataReader["UpdatedDate"]);

            if (dataReader["CreatedDate"] != DBNull.Value)
                dbConfigInfo.CreatedDate = Convert.ToDateTime(dataReader["CreatedDate"]);
        }
    }
}
