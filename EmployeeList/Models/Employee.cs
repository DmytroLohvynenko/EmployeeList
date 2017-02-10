using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeList.Models
{
    public class Employee
    {
        private enum JobType
        {
            CEO,
            BusinessAnalyst
        }
        public string Name { get; set; }

    }
}