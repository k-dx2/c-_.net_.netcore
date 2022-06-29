using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Details()
        {
            var p1 = new ProductClass
            {
                ProdId = "P123",
                ProdName = "PS5",
                ProdCategory = "Gaming",
                ProdMfd = new DateTime(2020, 10, 10),
                ProdExpd = new DateTime(2025, 10, 10)
            };

            return View(p1);
        }
    }
}