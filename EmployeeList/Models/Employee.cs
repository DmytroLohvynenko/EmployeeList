using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeList.Models
{
    public class Employee
    {
        public enum JobType
        {
            CEO,

            [EnumMember(Value = "Business Analyst")]
            BusinessAnalyst,
            Developer,
            QA
        }
        public string Name { get; set; }
        public JobType JobTitle { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Rate { get; set; }


    }
}