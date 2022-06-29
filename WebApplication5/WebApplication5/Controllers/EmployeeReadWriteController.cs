using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class EmployeeReadWriteController : Controller
    {
        // GET: EmployeeReadWrite
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmployeeReadWrite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeReadWrite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeReadWrite/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeReadWrite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeReadWrite/Edit/5
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

        // GET: EmployeeReadWrite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeReadWrite/Delete/5
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
