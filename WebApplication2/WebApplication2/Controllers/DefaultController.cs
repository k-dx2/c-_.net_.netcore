using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller

    {
        // GET: Default
        public ActionResult Index()
        {   
            return View();
        }

        public ActionResult Index1() // we can aslo give index1() instead of Index1() ,its not case sensitive
        {
            return View();
        }
        //the quick brown fox jumps over the lazy dog
        public ActionResult Index2()
        {
            return View();
        }
    }
}