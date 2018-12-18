using Shop___videopoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop___videopoint.Controllers
{
    public class Prouct2Controller : Controller
    {
        // GET: Prouct2
        public ActionResult Index()
        {
            Product2 product = new Product2
            {
                Name = "ASP.NET MVC for beginners",
                Description = "Kurs dla początkujących",
                Price = 100
            };
            return View(product);
        }
    }
}