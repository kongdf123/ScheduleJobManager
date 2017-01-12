using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EF
{
    [Table(name: "custom_job_details")]
    public class JobDetail
    {
        [Key]
        [Column(Order = 1)]
        public int JobId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "varchar"), MaxLength(200)]
        public string JobName { get; set; }

        [Column(TypeName = "varchar"), MaxLength(200), Required]
        public string JobServiceURL { get; set; }

        [Column(TypeName = "datetime"), Required]
        public string CreatedDate { get; set; }

        [Column(TypeName = "datetime"), Required]
        public string UpdatedDate { get; set; }

        [Column(TypeName = "datetime"), Required]
        public string StartDate { get; set; }

        [Column(TypeName = "datetime"), Required]
        public string EndDate { get; set; }

        public int PageSize { get; set; }

        public int Interval { get; set; }

        public bool State { get; set; }

    }
}
