using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class EmployeesDetails
    {
        [Key]
        public int EmployeesDetailId { get; set; }

        [Column(TypeName ="varchar(100)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string email { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName ="varchar(100)")]
        public string JobId { get; set; }
    }
}
