using Shop___videopoint.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Shop___videopoint.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string search = null)
        {
            IEnumerable<Category> model;
            if (!string.IsNullOrEmpty(search))
            {
                model = _db.Categories.Where(c => c.Name.Contains(search)).ToList();
            }
            else
            {
                model = _db.Categories.ToList();
            }
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