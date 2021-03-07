using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeServiceWebApiDemo.Models;

namespace EmployeeServiceWebApiDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            _db = db;
        }

        public IEnumerable<Employees> Get()
        {
            return _db.Employeeses.ToList();
        }

    }
}
