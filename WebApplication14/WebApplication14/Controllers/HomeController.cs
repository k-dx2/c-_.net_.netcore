using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> StudList = new List<string>();
            StudList.Add("Tony");
            StudList.Add("Steve");
            StudList.Add("Natasha");

            ViewData["Students"] = StudList;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Name = "Kunal";
            ViewBag.Profession = "Student";
            ViewBag.Age = 22;
            ViewBag.Time = DateTime.Now;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}