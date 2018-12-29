using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppAspNet.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            this.ViewBag.Message = "Ciao da ASP.NET MVC";
            this.ViewBag.CurrentDate = DateTime.Now.ToString();
            this.ViewBag.ShowDate = true;

            return View();
        }
    }
}