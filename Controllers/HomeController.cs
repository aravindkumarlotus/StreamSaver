using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StreamSaver.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult mitm()
        {
            return new FilePathResult("~/Views/Home/mitm.html", "text/html");
        }
    }
}