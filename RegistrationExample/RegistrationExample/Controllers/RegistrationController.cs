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
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Register()
        {
            return View("Registration", new UserViewModel() {Id = Guid.NewGuid()});
        }

        [HttpPost]
        public ActionResult RegisterUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Content("User registered succesessful");
            }
            return Content("Entered data invalid");
        }
    }
}