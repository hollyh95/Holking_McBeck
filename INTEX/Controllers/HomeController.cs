using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Client()
        {
            ViewBag.Message = "Client Portal";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Admin Portal";

            return View();
        }

        public ActionResult Employee()
        {
            ViewBag.Message = "Employee Portal";

            return View();
        }

        public ActionResult SalesRep()
        {
            ViewBag.Message = "SalesRep Portal";

            return View();
        }

        public ActionResult Pharmacolgy()
        {
            ViewBag.Message = "Pharmacolgy Portal";

            return View();
        }
    }
}