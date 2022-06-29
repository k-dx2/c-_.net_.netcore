using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;
namespace WebApplication19.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List <Employee> EmpList= new List<Employee>();

            EmpList.Add(new Employee() { EmpId = "EP101", EmpName = "Iron Man", EmpDept="Sales",EmpDoj= new DateTime(2020,10,10) });
            EmpList.Add(new Employee() { EmpId = "EP102", EmpName = "Captain America", EmpDept = "Marketing", EmpDoj = new DateTime(2020, 10, 10) });
            EmpList.Add(new Employee() { EmpId = "EP103", EmpName = "Thor", EmpDept = "Accounts", EmpDoj = new DateTime(2020, 01, 16) });
            EmpList.Add(new Employee() { EmpId = "EP104", EmpName = "Black Widow", EmpDept = "Sales", EmpDoj = new DateTime(2020,03, 11) });
            EmpList.Add(new Employee() { EmpId = "EP105", EmpName = "Spider Man", EmpDept = "Marketing", EmpDoj = new DateTime(2020, 07, 20) });

            return View(EmpList);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            Employee e1 = new Employee() { EmpId = "EP107", EmpName = "Black Panther", EmpDept = "Sales", EmpDoj = new DateTime(2020, 09, 21) };
            return View(e1);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string id = Request.Form["EmpId"];
                string name = Request.Form["EmpName"];
                string dept = Request.Form["EmpDept"];
                DateTime date = Convert.ToDateTime(Request.Form["EmpDoj"]);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            Employee e2 = new Employee() { EmpId = "EP108", EmpName = "Falcon", EmpDept = "Sales", EmpDoj = new DateTime(2020, 08, 10) };
            return View(e2);
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            Employee e3 = new Employee() { EmpId = "EP109", EmpName = "Hulk", EmpDept = "Accounts", EmpDoj = new DateTime(2020, 08, 10) };
            return View(e3);
        }

        // POST: Employee/Delete/5
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
