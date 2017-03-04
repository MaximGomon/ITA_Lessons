using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcExample.Models;

namespace MvcExample.Controllers
{
    public class TableController : Controller
    {
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Display(int id = 0)
        {
            var list = new List<TableItem>();
            for (int i = 0; i < id; i++)
            {
                list.Add(new TableItem
                {
                    Id = i,
                    Name = "Name " + i
                });
            }
            return View(list);
        }
    }
}