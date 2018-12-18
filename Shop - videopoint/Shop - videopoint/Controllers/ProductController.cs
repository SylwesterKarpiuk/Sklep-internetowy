using Shop___videopoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop___videopoint.Controllers
{
    public class ProductController : Controller
    {
        // GET: Prouct
        public ActionResult Index()
        {
            Product product = new Product();
            product.Name = "Książka ASP.NET MVC";
            product.Description = "Znajdziemy tutaj bardzo dużo wiedzy";
            product.Price = 100;
            return View(product);
        }
    }
}
