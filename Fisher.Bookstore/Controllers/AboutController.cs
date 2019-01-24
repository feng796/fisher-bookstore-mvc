using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
        public IActionResult History()
        {
            return Content("1995");
        }
        public IActionResult Location()
        {
            return Content("Columbus");
        }
    }
}