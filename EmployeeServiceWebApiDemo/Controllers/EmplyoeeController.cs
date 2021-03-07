using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeServiceWebApiDemo.Models;

namespace EmployeeServiceWebApiDemo.Controllers
{
    public class EmplyoeeController : ApiController
    {
        private readonly ApplicationDbContext _db;

        public EmplyoeeController(ApplicationDbContext db)
        {
            _db = db;
        }

    }
}
