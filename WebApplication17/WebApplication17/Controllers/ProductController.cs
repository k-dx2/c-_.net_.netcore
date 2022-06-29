using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;


namespace WebApplication17.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> ProdList = new List<Product>();
            ProdList.Add(new Product() { ProdId = "P101", ProdName = "PS5", ProdCat="Gaming",ProdMfd=new DateTime(2020,10,10)});
            ProdList.Add(new Product() { ProdId = "P102", ProdName = "Xbox One", ProdCat = "Gaming", ProdMfd = new DateTime(2020, 10, 10) });
            ProdList.Add(new Product() { ProdId = "P103", ProdName = "Nintendo Switch", ProdCat = "Gaming", ProdMfd = new DateTime(2020, 10, 10) });
            ProdList.Add(new Product() { ProdId = "P104", ProdName = "HP Omen", ProdCat = "Gaming", ProdMfd = new DateTime(2020, 10, 10) });
          
            return View(ProdList);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            


            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string name = Request.Form["ProdName"];
                string id = Request.Form["ProdId"];
                string catogry = Request.Form["ProdCat"];
                DateTime mfd =Convert.ToDateTime( Request.Form["ProdMfd"]);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
