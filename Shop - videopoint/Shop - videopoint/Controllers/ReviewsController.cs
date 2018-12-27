using Shop___videopoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop___videopoint.Controllers
{
    public class ReviewsController : BaseController
    {
        // GET: Reviews
        public ActionResult Index([Bind(Prefix = "id")] int productId)
        {
            var product = _db.Products.Find(productId);
            if (product!=null)
            {
                return View(product);
            }
            return HttpNotFound();
        }
        public ActionResult Create(int productId)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Review model)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(model);
                _db.SaveChanges();
                return RedirectToAction("index", new { id = model.ProductId });
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var review = _db.Reviews.Find(id);
            if (review != null)
            {
                return View(review);
            }
            else
            {
                return RedirectToAction("Index", "Products");
            }
        }
        [HttpPost]
        public ActionResult Edit([Bind(Exclude="Name")]Review model)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = model.ProductId });
            }
            return View(model);
            
        }
    }
}