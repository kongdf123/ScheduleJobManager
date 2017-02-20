using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Utility;

namespace Service.DAL
{
    public class SqlServerDbHelper
    {
        static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.AppSettings["SQLServerConnString"];
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new CustomException("系统无法与数据库建立连结，请您与系统管理员联系。", ExceptionType.Error, "错误信息：" + ex.ToString());
            }
            return connection;
        }

        static SqlConnection GetConnection(string connString)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connString;
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new CustomException("系统无法与数据库建立连结，请您与系统管理员联系。", ExceptionType.Error, "错误信息：" + ex.ToString());
            }
            return connection;
        }

        public static DataSet ExecuteDataTable(string connString, string commandText, SqlParameter[] commandParms)
        {
            SqlConnection sqlConnection = GetConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                sqlCommand.Parameters.Clear();
                return ds;
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
        }

        public static SqlDataReader ExecuteReader(string commandText, SqlParameter[] commandParms)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            try
            {
                SqlDataReader dbReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dbReader;
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
        }

        public static SqlDataReader ExecuteReader(string connString, string commandText, SqlParameter[] commandParms)
        {
            SqlConnection sqlConnection = GetConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            try
            {
                SqlDataReader dbReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                sqlCommand.Parameters.Clear();
                return dbReader;
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
        }

        public static T ExecuteScalar<T>(string connString, string commandText, SqlParameter[] commandParms)
        {
            SqlConnection sqlConnection = GetConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            try
            {
                object result = sqlCommand.ExecuteScalar();
                sqlCommand.Parameters.Clear();
                if (result != null)
                {
                    return (T)Convert.ChangeType(result, typeof(T));
                }
                return default(T);
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
        }

        public static T ExecuteScalar<T>(string commandText, SqlParameter[] commandParms)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            try
            {
                object result = sqlCommand.ExecuteScalar();
                sqlCommand.Parameters.Clear();
                if (result != null)
                {
                    return (T)Convert.ChangeType(result, typeof(T));
                }
                return default(T);
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
        }

        public static int ExecuteNonQuery(string commandText, SqlParameter[] commandParms)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            int rowCount = 0;
            try
            {
                rowCount = sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
            return rowCount;
        }

        static void PrepareCommand(SqlCommand sqlCommand, SqlParameter[] commandParms)
        {
            if (commandParms != null)
            {
                foreach (var parameter in commandParms)
                {
                    if (parameter.Value == null)
                    {
                        parameter.Value = DBNull.Value;
                    }
                    if (!sqlCommand.Parameters.Contains(parameter))
                    {
                        sqlCommand.Parameters.Add(parameter);
                    }
                }
            }
        }
    }
}
