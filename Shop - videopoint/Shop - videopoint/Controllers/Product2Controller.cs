using Shop___videopoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop___videopoint.Controllers
{
    public class Product2Controller : Controller
    {
        // GET: Prouct2
        public void Index()
        {
           
        }
        public ActionResult Display(int id)
        {
            Product2 product = new Product2
            {
                id = 1,
                Name = "ASP.NET MVC for beginners",
                Description = "Kurs dla początkujących",
                Price = 100
            };
            if (id == product.id)
            {
                return View(product);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}