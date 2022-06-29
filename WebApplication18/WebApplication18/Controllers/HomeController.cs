using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication18.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> sphones = new List<string>();
            sphones.Add("Apple");

            sphones.Add("Samsung");
            sphones.Add("Honor");
            sphones.Add("Xiaomi");

            ViewData["SmartPhone"] = sphones;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.StudName = "kunal";
            ViewBag.Age = 22;
            ViewBag.Profession = "Student";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}