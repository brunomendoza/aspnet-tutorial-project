using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld/Welcome
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            // Example: http://localhost:50147/HelloWorld/Welcome?name=John&numTimes=10
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}