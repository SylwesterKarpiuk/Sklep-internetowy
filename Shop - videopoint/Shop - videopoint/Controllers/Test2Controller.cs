using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop___videopoint.Controllers
{
    public class Test2Controller : Controller
    {
        // GET: Test2
        public ActionResult Index()
        {
            return Content("Witaj świecie2");
        }

        public ActionResult Hello2(string id)
        {
            ViewBag.Name = id;
            ViewBag.Weather = "Słońce świeci bardzo mocno";
            return View();
        }
    }
}