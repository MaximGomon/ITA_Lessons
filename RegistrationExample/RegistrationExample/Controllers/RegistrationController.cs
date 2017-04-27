using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BusinessLogic;
using BusinessLogic.Implementation;
using DataAccess.Repositories;
using DbEntity;
using RegistrationExample.Models;

namespace RegistrationExample.Controllers
{
    public class RegistrationController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();

        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Roles = _unitOfWork.Role.GetAllItems().Select(x =>
            new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();

            return View("Registration", new UserViewModel() { Id = Guid.NewGuid() });
        }

        [HttpPost]
        public ActionResult RegisterUser(UserViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = Mapper.Map<User>(model);
                user.Role = _unitOfWork.Role.GetById(model.RoleId);
                user.Salt =
                    String.Join("", 
                    Encoding.UTF8.GetBytes(user.Password.Substring(4).ToCharArray())
                        .Select(x => x.ToString()));
                _unitOfWork.User.Create(user);
                return Json(_unitOfWork.User.GetById(model.Id));
            }
            return Content("Entered data invalid");
        }
    }
}