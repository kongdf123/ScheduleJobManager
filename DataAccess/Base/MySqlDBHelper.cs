using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using JobMonitor.Utility;

namespace DataAccess.DAL
{
    public class MySqlDbHelper
    {
        static MySqlConnection GetConnection() {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.AppSettings["MySQLServerConnString"];
            try {
                connection.Open();
            }
            catch ( Exception ex ) {
                connection.Close();
                throw new CustomException("系统无法与数据库建立连结，请您与系统管理员联系。", ExceptionType.Error, "错误信息：" + ex.ToString());
            }
            return connection;
        }

        public static MySqlDataReader ExecuteReader(string commandText, MySqlParameter[] commandParms) {
            MySqlConnection mySqlConnection = GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, mySqlConnection);
            PrepareCommand(mySqlCommand, commandParms);
            try {
                MySqlDataReader dbReader = mySqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dbReader;
            }
            catch ( Exception ex ) {
                if ( mySqlConnection.State == ConnectionState.Open ) {
                    mySqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
        }

        public static T ExecuteScalar<T>(string commandText, MySqlParameter[] commandParms) {
            MySqlConnection mySqlConnection = GetConnection();
            try {
                object result = MySqlHelper.ExecuteScalar(mySqlConnection, commandText, commandParms);
                if ( result != null ) {
                    return (T)Convert.ChangeType(result, typeof(T));
                }
                return default(T);
            }
            catch ( Exception ex ) {
                if ( mySqlConnection.State == ConnectionState.Open ) {
                    mySqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
        }

        public static int ExecuteNonQuery(string commandText, MySqlParameter[] commandParms) {
            MySqlConnection mySqlConnection = GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, mySqlConnection);
            PrepareCommand(mySqlCommand, commandParms);
            int rowCount = 0;
            try {
                rowCount = mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch ( Exception ex ) {
                if ( mySqlConnection.State == ConnectionState.Open ) {
                    mySqlConnection.Close();
                }
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\n\t错误信息：" + ex.ToString());
            }
            return rowCount;
        }

        static void PrepareCommand(MySqlCommand mySqlCommand, MySqlParameter[] commandParms) {
            if ( commandParms != null ) {
                foreach ( var parameter in commandParms ) {
                    if ( parameter.Value == null ) {
                        parameter.Value = DBNull.Value;
                    }
                    mySqlCommand.Parameters.Add(parameter);
                }
            }
        }
    }
}
