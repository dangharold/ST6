using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranCongMinh_1911060177.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            return View("hello");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "hello hello";
            ViewBag.Message = "bye";
            ViewBag.Message = "heheheh";
            ViewBag.Message = "kjhdgufd";
            ViewBag.Message = "kekekekekke";
            ViewBag.Message = "Huynh Hai Dang";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
