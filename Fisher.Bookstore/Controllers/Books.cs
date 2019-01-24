using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("index");
        }
        public IActionResult New()
        {
            return Content("new");
        }

        public IActionResult BestSellers()
        {
            return Content("best-seller");
        }
    }
}