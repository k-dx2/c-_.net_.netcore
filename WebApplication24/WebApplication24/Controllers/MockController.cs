using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Controllers
{
    public class MockController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
