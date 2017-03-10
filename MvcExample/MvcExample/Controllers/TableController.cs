using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MvcExample.Models;

namespace MvcExample.Controllers
{
    public class TableController : Controller
    {
        [HttpGet]
        [LogFilter]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Display()
        {
            ViewBag.Items = MvcApplication.Items;
            //var list = new List<TableItem>();
            //for (int i = 0; i < id; i++)
            //{
            //    list.Add(new TableItem
            //    {
            //        Id = i,
            //        Name = "Name " + i
            //    });
            //}
            return View();
        }

        [HttpGet]
        [LogFilter]
        public ActionResult Add()
        {
            return View();
        }

        [HttpGet]
        [LogFilter]
        public ActionResult Edit(int id)
        {
            return View("Add", MvcApplication.Items.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public ActionResult Add(TableItem item)
        {
            var existingItem = MvcApplication.Items.FirstOrDefault(x => x.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Name = item.Name;
            }
            else
            {
                MvcApplication.Items.Add(item);
            }
            return RedirectToAction("Display");
        }
    }
}