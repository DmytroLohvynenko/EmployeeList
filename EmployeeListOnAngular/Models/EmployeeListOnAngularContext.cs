using System.Data.Entity;

namespace EmployeeListOnAngular.Models
{
    public class EmployeeListOnAngularContext : DbContext
    {    
        public EmployeeListOnAngularContext() : base("name=EmployeeListOnAngularContext")
        {
        }

        public System.Data.Entity.DbSet<EmployeeListOnAngular.Models.Employee> Employees { get; set; }
    }
}
