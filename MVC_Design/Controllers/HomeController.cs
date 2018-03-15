using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Design.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Players()
        {
            return View();
        }
        public ActionResult Schedule()
        {
            return View();
        }
        public ActionResult Teams()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}