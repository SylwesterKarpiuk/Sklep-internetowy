using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop___videopoint.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var selectCategories = from c in _db.Categories
                                   where c.Name.Length < 7
                                   select c;
            var selectedCategories2 = _db.Categories.Where(c => c.Name.Length < 7);

            var model = _db.Categories.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}