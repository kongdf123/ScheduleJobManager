using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Text;
using System.Data;

namespace BudStudio.DgvColumn.SFL
{
    public class OleDbHelper
    {
        private static OleDbConnection GetNewConnection()
        {
            OleDbConnection oleDbConnection = new OleDbConnection();
            oleDbConnection.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["OleDbConnString"];

            try
            {
                oleDbConnection.Open();
            }
            catch (Exception ex)
            {
                oleDbConnection.Close();
                throw new CustomException("系统无法与数据库建立连结，请您与系统管理员联系。", ExceptionType.Error, "错误信息：" + ex.Message);
            }
            return oleDbConnection;
        }

        /// <summary>
        /// 执行SQL语句，并返回一个OleDbDataReader对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <returns>OleDbDataReader对象</returns>
        public static OleDbDataReader ExecuteReader(string commandText, OleDbParameter[] commandParm)
        {
            OleDbConnection oleDbConnection = GetNewConnection();
            OleDbCommand oleDbCommand = new OleDbCommand(commandText, oleDbConnection);
            PrepareCommand(oleDbCommand, commandParm);
            try
            {
                OleDbDataReader dbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dbDataReader;
            }
            catch (Exception e)
            {
                oleDbConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
        }



        /// <summary>
        /// 执行SQL语句，不返回任何对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        public static int ExecuteNonQuery(string commandText, OleDbParameter[] commandParm)
        {
            OleDbConnection oleDbConnection = GetNewConnection();
            OleDbCommand oleDbCommand = new OleDbCommand(commandText, oleDbConnection);
            PrepareCommand(oleDbCommand, commandParm);
            int rowCount = 0;
            try
            {
                rowCount = oleDbCommand.ExecuteNonQuery();
                oleDbConnection.Close();
            }
            catch (Exception e)
            {
                oleDbConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
            return rowCount;
        }

        private static void PrepareCommand(OleDbCommand oleDbCommand, OleDbParameter[] commandParms)
        {
            if (commandParms != null)
            {
                foreach (OleDbParameter parameter in commandParms)
                {
                    if (parameter.Value == null)
                    {
                        parameter.Value = DBNull.Value;
                    }
                    oleDbCommand.Parameters.Add(parameter);
                }
            }
        }
    }
}
