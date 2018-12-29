using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{

        //    return "This is my default action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        public string WelcomeA()
        {
            return "This is the Welcome action method...";
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        // http://localhost:xxxx/HelloWorld/Welcome?name=Rick&numtimes=4
        public string WelcomeB(string name, int numTimes = 1)
        {

            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        // http://localhost:xxx/HelloWorld/Welcome/3?name=Rick
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}