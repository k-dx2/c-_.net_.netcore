using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> MobileList = new List<string>();

            MobileList.Add("Apple");
            MobileList.Add("Samsung");
            MobileList.Add("Google");
            MobileList.Add("Xiaomi");

            ViewData["SmartPhones"] = MobileList;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.ProductId = "P123";
            ViewBag.ProductPrice = 59999.99;
            ViewBag.Manufacturer = "Apple";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}