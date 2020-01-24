using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ar259015MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A little bit about me.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Information.";

            return View();
        }
    }
}