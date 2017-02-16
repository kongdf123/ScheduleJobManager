using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entity
{
    public class DBConfigInfo
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
                return string.Format("Server={0};Database={1};User Id={2};Password = {3};", ServerAddress, DBName, UserName, Password);
            }
        }

        public DateTime UpdatedDate { get; set; }

        public DateTime CreatedDate { get; set; }
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
