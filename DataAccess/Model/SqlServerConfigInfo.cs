using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entity
{
    public class SqlServerConfigInfo
    {
        public int Id { get; set; }

        public string ServerAddress { get; set; }

        public string DBName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string EquipmentNum { get; set; }

        public byte StoredType { get; set; }

        public int PageSize { get; set; }

        public int MaxCapacity { get; set; }

        public string ConnString {
            get {
                if ( !string.IsNullOrEmpty(Password) ) {
                    return string.Format("Provider=sqloledb;Data Source={0};Initial Catalog={1};User Id = {2}; Password ={3}; ", ServerAddress, DBName, UserName, Password);
                }
                return string.Format("Provider=sqloledb;Data Source={0};Initial Catalog={1};User Id = {2};Integrated Security=SSPI;", ServerAddress, DBName, UserName);
            }
        }

        public byte DBType { get; set; }

        public byte AuthenticatedType { get; set; }

        public byte ServerState { get; set; }

        public DateTime UpdatedDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }

    public enum DBTypeEnum
    {
        SqlServer = 1,
        MySQL = 2,
        Oracle = 3
    }

    /// <summary>
    /// 数据库服务器状态
    /// </summary>
    public enum ServerStateEnum
    {
        Enabled = 1,
        Disabled = 2
    }

    /// <summary>
    /// 数据库登陆验证方式
    /// </summary>
    public enum AuthenticatedTypeEnum
    {
        /// <summary>
        /// Sql Server账户
        /// </summary>
        SqlServer = 0,

        /// <summary>
        /// Windows系统集成
        /// </summary>
        Windows = 1
    }

    /// <summary>
    /// 存储方式，1：按每页，2：按数据总量
    /// </summary>
    public enum StoredTypeEnum
    {
        PageSize = 1,
        MaxCapacity = 2
    }
}
