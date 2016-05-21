using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcCORSSamples.Filters;

namespace AspNetMvcCORSSamples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowCORS]
        public ActionResult Hello(string name)
        {
            return Json(new { Greeting = $"Hi, {name}" });
        }
    }
}