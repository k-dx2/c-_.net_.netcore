using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeDetails()
        {
            return View();
        }

        public ActionResult EmployeeLocation()
        {
            return View();
        }

    }
}