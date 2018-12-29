using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
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

        public ActionResult Customer()
        {
            ViewBag.Message = "List customer page.";

            return View();
        }

        public ActionResult Basic()
        {
            ViewBag.Message = "Sample basic with knockout.";
            return View();
        }
        public ActionResult Advanced()
        {
            ViewBag.Message = "Sample advanced with knockout.";

            var person = new Person
            {
                FirstName = "Nicola",
                LastName = "Tuccella"
            };


            return View(person);
        }
    }
}