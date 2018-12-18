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
        public void Index()
        {
          
        }
        [ActionName("Pokaz")]
        [Authorize]
        public ActionResult Display(int id)
        {
            throw new Exception("Coś poszło nie tak");
            Product product = new Product();
            product.id = 1;
            product.Name = "Książka ASP.NET MVC";
            product.Description = "Znajdziemy tutaj bardzo dużo wiedzy";
            product.Price = 100;

            if (product.id == id)
            {
                return View("~/Views/Product/Display.cshtml",product);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
       
        
    }
}
