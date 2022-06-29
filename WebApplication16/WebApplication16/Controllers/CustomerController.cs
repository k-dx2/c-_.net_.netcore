using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models;
namespace WebApplication16.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> CustList = new List<Customer>();
            CustList.Add(new Customer() { Name ="Tony",Surname="Stark",Age=21,Gender="Male" });
            CustList.Add(new Customer() { Name = "Steve", Surname = "Rogers", Age = 21, Gender = "Male" });
            CustList.Add(new Customer() { Name = "Natsaha", Surname = "Romanova", Age = 21, Gender = "Female" });
            CustList.Add(new Customer() { Name = "Bruce", Surname = "Banner", Age = 21, Gender = "Male" });

            return View(CustList);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int? id)
        {
            Customer c3 = new Customer() { Name = "Wade", Surname = "Wilson", Gender = "Male", Age = 21 };
            return View(c3);
           
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string name = Request.Form["Name"];
                string surname = Request.Form["Surname"];
                int age = Convert.ToInt32(Request.Form["Age"]);
                string gender = Request.Form["Gender"];

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int? id)
        {
            Customer c1 = new Customer() {Name="Peter",Surname="Parker",Gender="Male",Age=21 };
            return View(c1);
        }

        // POST: Customer/Edit/5
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

        // GET: Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            Customer c2 = new Customer() { Name = "T", Surname = "Challa", Gender = "Male", Age = 21 };
            return View(c2);
           
        }

        // POST: Customer/Delete/5
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
