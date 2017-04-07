using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DbEntity;
using RegistrationExample.Models;

namespace RegistrationExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Register", "Registration");
        }
    }
}