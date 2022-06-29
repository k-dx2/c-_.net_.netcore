using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication20.Models;
namespace WebApplication20.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> StudList = new List<Student>();
            StudList.Add(new Student() { StudName = "Kunal", StudClass = 12, StudRollNo = 101, StudAddress = "Nagpur" });
            StudList.Add(new Student() { StudName = "Amal", StudClass = 12, StudRollNo = 102, StudAddress = "Kerala" });
            StudList.Add(new Student() { StudName = "Nalanda", StudClass = 11, StudRollNo = 103, StudAddress = "Darjeeling" });
            StudList.Add(new Student() { StudName = "Sumant", StudClass = 12, StudRollNo = 104, StudAddress = "Banka" });

            ViewBag.StudSub1 = "Maths";
            ViewBag.StudSub2 = "Chemisrty";
            ViewBag.StudSub3 = "Physics";
            ViewBag.StudSub4 = "English";
            ViewBag.StudSub5 = "Computer science";

            List<string> notebooks = new List<string>() { "Classmate", "Camlin", "Navneet", "Archie" };
            ViewData["notebooks"] = notebooks;

            List<string> names = new List<string>() { "Kunal", "Amal", "Harry", "Suman" };

            IEnumerable<string> query = from s in names
                                        where s.Length == 5
                                        select s;

            ViewData["Nameof5"] = query.ToList();// to convert Ienumerable to list as ViewData works with list


            return View(StudList);


        }




        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            Student s1 = new Student() { StudName = "Adarsh", StudClass = 12, StudRollNo = 105, StudAddress = "Patna" };
            return View(s1);
        }

        // GET: Student/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                int rollno = Convert.ToInt32(Request.Form["StudRollNo"]);
                string name = Request.Form["StudName"];
                string address = Request.Form["StudAddress"];
                int clas = Convert.ToInt32(Request.Form["StudClass"]);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            Student s1 = new Student() { StudName = "Potta", StudClass = 12, StudRollNo = 106, StudAddress = "Chennai" };

            return View(s1);
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            Student s1 = new Student() { StudName = "Kunal", StudClass = 12, StudRollNo = 101, StudAddress = "Nagpur" };

            return View(s1);

        }

        // POST: Student/Delete/5
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


