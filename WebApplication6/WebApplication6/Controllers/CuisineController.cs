using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //not necessary
        public ActionResult Index()
        {
            return View();
        }

        /*
        //Search action
        public ActionResult Search(string name ="French") //default parameter
        {
            return Content("The name of Cuisine passed is : " + name);
        }

        
        */
        
        /*
        //Redirecting to action
        public ActionResult Search(string name="French")
        {
            return RedirectToAction("Index", "Home",new { name = name });
        }
        */

        /*
        //Redirecting to Route
        public ActionResult Search(string name = "French")
        {
            return RedirectToRoute("Default", new {controller="Home" ,action="contact"});
        }
        */

        /*
        //returning a file
        public ActionResult Search(string name = "French")
        {
            return File(Server.MapPath("~/Content/Site.css"), "text/css");
        }
        */

        //returning a Json 
        public ActionResult Search(string name="French")
        {
            return Json(new { Message = name, Name = "Kunal" }, JsonRequestBehavior.AllowGet);
        }
    }
}