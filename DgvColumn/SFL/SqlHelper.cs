using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace BudStudio.DgvColumn.SFL
{
    public class SqlHelper
    {
        private static SqlConnection GetNewConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["SqlServerConnString"];

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                throw new CustomException("系统无法与数据库建立连结，请您与系统管理员联系。", ExceptionType.Error, "错误信息：" + ex.Message);
            }
            return sqlConnection;
        }

        /// <summary>
        /// 执行SQL语句，并返回一个SqlDataReader对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <returns>SqlDataReader对象</returns>
        public static SqlDataReader ExecuteReader(string commandText, SqlParameter[] commandParm)
        {
            SqlConnection sqlConnection = GetNewConnection();
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParm);
            try
            {
                SqlDataReader dbDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dbDataReader;
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
        }



        /// <summary>
        /// 执行SQL语句，不返回任何对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        public static int ExecuteNonQuery(string commandText, SqlParameter[] commandParm)
        {
            SqlConnection sqlConnection = GetNewConnection();
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParm);
            int rowCount = 0;
            try
            {
                rowCount = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
            return rowCount;
        }

        private static void PrepareCommand(SqlCommand sqlCommand, SqlParameter[] commandParms)
        {
            if (commandParms != null)
            {
                foreach (SqlParameter parameter in commandParms)
                {
                    if (parameter.Value == null)
                    {
                        parameter.Value = DBNull.Value;
                    }
                    sqlCommand.Parameters.Add(parameter);
                }
            }
        }
    }
}
