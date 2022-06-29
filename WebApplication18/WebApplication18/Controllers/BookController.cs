using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication18.Models;
namespace WebApplication18.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            List<Book> BookList = new List<Book>();
            BookList.Add(new Book() { BookId = "B101",BookName ="White Tiger",BookWriter="Aravind Adiga",BookPrice=49.99,BookPublisher="Penguin"});
            BookList.Add(new Book() { BookId = "B102", BookName = "Grace", BookWriter = "Paul Lynch", BookPrice = 49.99, BookPublisher = "A1" });
            BookList.Add(new Book() { BookId = "B103", BookName = "Everyone has a Story",  BookWriter = "Savi Sharma", BookPrice = 59.99, BookPublisher = "Westland" });
            BookList.Add(new Book() { BookId = "B104", BookName = "The Monk Who sold his Ferrari",  BookWriter = "Robin Sharma", BookPrice = 39.99, BookPublisher = "Jaico" });

            return View(BookList);

        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {   
                string Bid= Request.Form["BookId"];
                string Bname = Request.Form["BookName"];
                string Bwriter = Request.Form["BookWriter"];
                string Bpublisher = Request.Form["BookPublisher"];
                double Bprice = Convert.ToDouble(Request.Form["BookPrice"]);
               
                
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
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

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
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
