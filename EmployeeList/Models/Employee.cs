using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Job title")]
        public JobType JobTitle { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Employment Date")]
        public DateTime EmploymentDate { get; set; }
        
        [DataType(DataType.Currency)]
        public int Rate { get; set; }


    }
}