using System;
using System.ComponentModel;

namespace EmployeeListOnAngular.Models
{
    public class Employee
    {
        public enum JobType
        {
            CEO,

            [Description("Business Analyst")]
            BusinessAnalyst,
            Developer,
            QA
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public decimal Rate { get; set; }
        public JobType JobTitle { get; set; }
    }
}