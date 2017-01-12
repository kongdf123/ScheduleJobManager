using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EF
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class QuartzDbContext : DbContext
    {
        public QuartzDbContext() : base(nameOrConnectionString: "QuartzDbContext") {}

        public DbSet<JobDetail> JobDetails { get; set; }


    }
}
