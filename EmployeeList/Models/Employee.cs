using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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

            [Display(Name = "Business Analyst")]
            BusinessAnalyst,
            Developer,
            QA
        }

        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Job title")]
        public JobType JobTitle { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Employment Date")]
        public DateTime EmploymentDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Rate { get; set; }
    }
}