using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using JobMonitor.Utility;

namespace Service.DAL
{
    public class SqlServerDbHelper
    {
        static OleDbConnection GetConnection()
        {
            OleDbConnection connection = new OleDbConnection();
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

        static OleDbConnection GetConnection(string connString)
        {
            OleDbConnection connection = new OleDbConnection();
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

        public static DataSet ExecuteDataTable(string connString, string commandText, OleDbParameter[] commandParms)
        {
            OleDbConnection sqlConnection = GetConnection(connString);
            OleDbCommand sqlCommand = new OleDbCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            try
            {
                OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(sqlCommand);
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

        public static OleDbDataReader ExecuteReader(string commandText, OleDbParameter[] commandParms)
        {
            OleDbConnection sqlConnection = GetConnection();
            OleDbCommand sqlCommand = new OleDbCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            try
            {
                OleDbDataReader dbReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
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

        public static OleDbDataReader ExecuteReader(string connString, string commandText, OleDbParameter[] commandParms)
        {
            OleDbConnection sqlConnection = GetConnection(connString);
            OleDbCommand sqlCommand = new OleDbCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParms);
            try
            {
                OleDbDataReader dbReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
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

        public static T ExecuteScalar<T>(string connString, string commandText, OleDbParameter[] commandParms)
        {
            OleDbConnection sqlConnection = GetConnection(connString);
            OleDbCommand sqlCommand = new OleDbCommand(commandText, sqlConnection);
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

        public static T ExecuteScalar<T>(string commandText, OleDbParameter[] commandParms)
        {
            OleDbConnection sqlConnection = GetConnection();
            OleDbCommand sqlCommand = new OleDbCommand(commandText, sqlConnection);
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

        public static int ExecuteNonQuery(string commandText, OleDbParameter[] commandParms)
        {
            OleDbConnection sqlConnection = GetConnection();
            OleDbCommand sqlCommand = new OleDbCommand(commandText, sqlConnection);
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

        static void PrepareCommand(OleDbCommand sqlCommand, OleDbParameter[] commandParms)
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
