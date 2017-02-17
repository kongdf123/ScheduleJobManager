using DataAccess.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccess.DAL
{
    public class SqlServerConfigInfoDAL
    {
        public static SqlServerConfigInfoDAL CreateInstance()
        {
            return new SqlServerConfigInfoDAL();
        }

        public int Insert(SqlServerConfigInfo dbConfigInfo)
        {
            dbConfigInfo.UpdatedDate = DateTime.Now;
            dbConfigInfo.CreatedDate = DateTime.Now;

            string sqlText = @"INSERT INTO `custom_db_config`
                                (`Id`,
                                `ServerAddress`,
                                `DBName`,
                                `UserName`,
                                `Password`,
                                `UpdatedDate`,
                                `CreatedDate`,
                                `EquipmentNum`,
                                `PageSize`,
                                `MaxCapacity`,
                                `StoredType`)
                                VALUES
                                (@Id,
                                @ServerAddress,
                                @DBName,
                                @UserName,
                                @Password,
                                @UpdatedDate,
                                @CreatedDate,                                
                                @EquipmentNum,
                                @PageSize,
                                @MaxCapacity,
                                @StoredType); SELECT LAST_INSERT_ID();";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Id", MySqlDbType.Int32 ){ Value = dbConfigInfo.Id },
                new MySqlParameter("@DBName", MySqlDbType.VarChar , 45 ){ Value = dbConfigInfo.DBName },
                new MySqlParameter("@ServerAddress", MySqlDbType.VarChar , 30 ){ Value = dbConfigInfo.ServerAddress },
                new MySqlParameter("@UserName", MySqlDbType.VarChar , 45){ Value = dbConfigInfo.UserName},
                new MySqlParameter("@Password", MySqlDbType.VarChar, 45){ Value = dbConfigInfo.Password},
                new MySqlParameter("@UpdatedDate" , MySqlDbType.DateTime){ Value = dbConfigInfo.UpdatedDate },
                new MySqlParameter("@CreatedDate", MySqlDbType.DateTime){ Value = dbConfigInfo.CreatedDate},
                new MySqlParameter("@EquipmentNum", MySqlDbType.VarChar , 25 ){ Value = dbConfigInfo.EquipmentNum },
                new MySqlParameter("@PageSize", MySqlDbType.Int32 ){ Value = dbConfigInfo.PageSize },
                new MySqlParameter("@MaxCapacity", MySqlDbType.Int32 ){ Value = dbConfigInfo.MaxCapacity },
                new MySqlParameter("@StoredType", MySqlDbType.Byte ){ Value = dbConfigInfo.StoredType }
            };
            return MySqlDbHelper.ExecuteScalar<int>(sqlText, parameters);
        }

        public int Update(SqlServerConfigInfo dbConfigInfo)
        {
            dbConfigInfo.UpdatedDate = DateTime.Now;
            string sqlText = @"UPDATE `custom_db_config`
                                SET
                                `ServerAddress` = @ServerAddress,
                                `DBName` = @DBName,
                                `UserName` = @UserName,
                                `Password` = @Password,
                                `UpdatedDate` = @UpdatedDate,
                                `CreatedDate` = @CreatedDate,
                                `EquipmentNum`=@EquipmentNum,
                                `PageSize`=@PageSize,
                                `MaxCapacity`=@MaxCapacity,
                                `StoredType`=@StoredType
                                WHERE `Id` = @Id;";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Id", MySqlDbType.Int32 ){ Value = dbConfigInfo.Id },
                new MySqlParameter("@DBName", MySqlDbType.VarChar , 45 ){ Value = dbConfigInfo.DBName },
                new MySqlParameter("@ServerAddress", MySqlDbType.VarChar , 30 ){ Value = dbConfigInfo.ServerAddress },
                new MySqlParameter("@UserName", MySqlDbType.VarChar , 45){ Value = dbConfigInfo.UserName},
                new MySqlParameter("@Password", MySqlDbType.VarChar, 45){ Value = dbConfigInfo.Password},
                new MySqlParameter("@UpdatedDate" , MySqlDbType.DateTime){ Value = dbConfigInfo.UpdatedDate },
                new MySqlParameter("@CreatedDate", MySqlDbType.DateTime){ Value = dbConfigInfo.CreatedDate},
                new MySqlParameter("@EquipmentNum", MySqlDbType.VarChar , 25 ){ Value = dbConfigInfo.EquipmentNum },
                new MySqlParameter("@PageSize", MySqlDbType.Int32 ){ Value = dbConfigInfo.PageSize },
                new MySqlParameter("@MaxCapacity", MySqlDbType.Int32 ){ Value = dbConfigInfo.MaxCapacity },
                new MySqlParameter("@StoredType", MySqlDbType.Byte ){ Value = dbConfigInfo.StoredType }
            };
            return MySqlDbHelper.ExecuteNonQuery(sqlText, parameters);
        }

        public int Delete(int id)
        {
            string sqlText = "DELETE FROM `custom_db_config` WHERE `Id` = @Id;";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Id" , MySqlDbType.Int32){ Value = id }
            };
            return MySqlDbHelper.ExecuteNonQuery(sqlText, parameters);
        }

        public SqlServerConfigInfo Get(int id)
        {
            SqlServerConfigInfo dbConfigInfo = null;
            string sqlText = @" SELECT `Id`,
                                    `ServerAddress`,
                                    `DBName`,
                                    `UserName`,
                                    `Password`,
                                    `UpdatedDate`,
                                    `CreatedDate`,
                                    `EquipmentNum`,
                                    `PageSize`,
                                    `MaxCapacity`,
                                    `StoredType`
                                FROM `custom_db_config` 
                                WHERE `Id` = @Id;";
            MySqlParameter[] parameters =
            {
                 new MySqlParameter("@Id" , MySqlDbType.Int32){ Value = id }
            };

            MySqlDataReader sqlDataReader = MySqlDbHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                dbConfigInfo = new SqlServerConfigInfo();
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

            int recordsTotal = MySqlDbHelper.ExecuteScalar<int>("SELECT COUNT(*) FROM custom_db_config " + sqlWhere, listParms.ToArray());

            string sqlText = @" SELECT `Id`,
                                    `ServerAddress`,
                                    `DBName`,
                                    `UserName`,
                                    `Password`,
                                    `UpdatedDate`,
                                    `CreatedDate`,
                                    `EquipmentNum`,
                                    `PageSize`,
                                    `MaxCapacity`,
                                    `StoredType`
                                FROM `custom_db_config`  " + sqlWhere + " ORDER BY Id DESC LIMIT " + (curPage - 1) * pageSize + "," + pageSize;
            List<SqlServerConfigInfo> list = new List<SqlServerConfigInfo>();
            MySqlDataReader sqlDataReader = MySqlDbHelper.ExecuteReader(sqlText, listParms.ToArray());

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
                SqlServerConfigInfo dbConfigInfo = new SqlServerConfigInfo();
                ReadRecordData(sqlDataReader, dbConfigInfo);
                list.Add(dbConfigInfo);
            }
            sqlDataReader.Close();
            pageData.PageList = list;
            return pageData;
        }

        void ReadRecordData(IDataReader dataReader, SqlServerConfigInfo dbConfigInfo)
        {
            if (dataReader["Id"] != DBNull.Value)
                dbConfigInfo.Id = Convert.ToInt32(dataReader["Id"]);

            if (dataReader["ServerAddress"] != DBNull.Value)
                dbConfigInfo.ServerAddress = Convert.ToString(dataReader["ServerAddress"]);

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

            if (dataReader["EquipmentNum"] != DBNull.Value)
            {
                dbConfigInfo.EquipmentNum = Convert.ToString(dataReader["EquipmentNum"]);
            }
            if (dataReader["StoredType"] != DBNull.Value)
            {
                dbConfigInfo.StoredType = Convert.ToByte(dataReader["StoredType"]);
            }
            if (dataReader["PageSize"] != DBNull.Value)
            {
                dbConfigInfo.PageSize = Convert.ToInt32(dataReader["PageSize"]);
            }
            if (dataReader["MaxCapacity"] != DBNull.Value)
            {
                dbConfigInfo.MaxCapacity = Convert.ToInt32(dataReader["MaxCapacity"]);
            }
        }
    }
}
