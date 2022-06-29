using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewStud()
        {
            List<Student> ls = new List<Student>();
            
            var s1 = new Student();
            s1.StudRollNo = 101;
            s1.StudName = "Tom";
            s1.StudClass = 12;
            s1.StudAddress = "California";

            ls.Add(s1);

            var s2 = new Student();
            s2.StudRollNo = 100;
            s2.StudName = "Mike";
            s2.StudClass = 12;
            s2.StudAddress = "Delhi";

            ls.Add(s2);

            var s3 = new Student();
            s3.StudRollNo = 102;
            s3.StudName = "Joker";
            s3.StudClass = 11;
            s3.StudAddress = "New York";

            ls.Add(s3);

            return View(ls);
        }
        public ActionResult ViewFile()
        {
            return File(Server.MapPath("~/Controllers/StudentController.cs"), "text/cs");
        }

        public ActionResult ViewJson(string n="Kunal")
        {
            return Json(new { Message = "Hello", Name = n }, JsonRequestBehavior.AllowGet);
        }


    }
}