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

        static List<Product> _products = new List<Product>
        {
            new Product{ id = 1, Name = "Myszka", Description="Opis myszki", Price = 15 },
            new Product{ id = 2, Name = "Klawiatura", Description="Opis klawiatury", Price = 25 },
            new Product{ id = 3, Name = "Słuchawki", Description="Opis słuchawek", Price = 60 },
            new Product{ id = 4, Name = "Monitor", Description="Opis monitora", Price = 500 }
        };

        // GET: Product
        public ActionResult Index()
        {
            var model = _products;
            return View(model);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var model = _products.FirstOrDefault(p => p.id == id);

            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product collection)
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product collection)
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
