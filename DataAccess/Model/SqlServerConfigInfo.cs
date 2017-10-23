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
                return $"Provider=SQLOLEDB;PWD=;UID={this.UserName};Database={this.DBName};Server={this.ServerAddress}";
            }
        }

        public byte DBType { get; set; }

        public byte AuthenticatedType { get; set; }

        public byte ServerState { get; set; }

        public DateTime UpdatedDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
