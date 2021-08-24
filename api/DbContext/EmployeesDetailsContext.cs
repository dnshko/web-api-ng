using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class EmployeesDetailsContext:DbContext
    {
        public EmployeesDetailsContext(DbContextOptions<EmployeesDetailsContext> options):base(options)
        {

        }

        public DbSet<EmployeesDetails> EmployeesDetails { get; set; }
    }
}
