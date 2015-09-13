using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CoffeeV2.Models;

namespace CoffeeV2.Controllers
{
    public class HomeController : Controller
    {
        CoffeeContext db = new CoffeeContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TabStripOrder()
        {
            return View();
        }

        public ActionResult Window()
        {
            return View();
        }

    }
}
