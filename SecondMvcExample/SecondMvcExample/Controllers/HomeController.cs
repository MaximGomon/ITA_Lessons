using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondMvcExample.Models;

namespace SecondMvcExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        [Logging]
        public ActionResult Display()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Animal item)
        {
            return RedirectToAction("Display");
        }
    }
}