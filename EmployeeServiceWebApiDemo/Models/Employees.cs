using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeServiceWebApiDemo.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}