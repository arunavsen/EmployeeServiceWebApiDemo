using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Web.Http;
using EmployeeServiceWebApiDemo.Models;

namespace EmployeeServiceWebApiDemo.Controllers
{
    public class StudentController : ApiController
    {
        List<Student> students = new List<Student>()
        {
            new Student(){Id = 1,Name = "Student 1"},
            new Student(){Id = 2,Name = "Student 2"},
            new Student(){Id = 3,Name = "Student 3"}
        };

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        public Student Get(int id)
        {
            return students.FirstOrDefault(m => m.Id == id);
        }

        [Route("api/Student/GetStudentCourse/{id}")]
        public IEnumerable<string> GetStudentCourse(int id)
        {
            if (id == 1)
            {
                return new List<string>(){"Asp.Net", "Html","CSS"};
            }else if (id == 2)
            {
                return new List<string>() { "Node", "Express", "Mongo DB" };
            }
            else
            {
                return new List<string>() { "PHP", "Laravel", "CodeIgnitor" };
            }
        }
    }
}
