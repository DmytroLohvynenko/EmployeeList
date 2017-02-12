using System;
using System.Data.Entity.Migrations;
using EmployeeListOnAngular.Models;

namespace EmployeeListOnAngular.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeListOnAngular.Models.EmployeeListOnAngularContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeListOnAngular.Models.EmployeeListOnAngularContext context)
        {
            context.Employees.AddOrUpdate(x => x.EmployeeId,
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "Giacomo",
                    LastName = "Guilizzoni",
                    JobTitle = Employee.JobType.CEO,
                    EmploymentDate = new DateTime(2014,12,12),
                    Rate = 10                   
                },
                new Employee()
                {
                    EmployeeId = 2,
                    FirstName = "Marco",
                    LastName = "Botton",
                    JobTitle = Employee.JobType.Developer,
                    EmploymentDate = new DateTime(2015,10,1),
                    Rate = 20
                }
                );
        }
    }
}
