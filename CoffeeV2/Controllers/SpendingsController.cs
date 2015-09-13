using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CoffeeV2.Models;

namespace CoffeeV2.Controllers
{
    public class SpendingsController : Controller
    {
        // GET: Spendings

        CoffeeContext db = new CoffeeContext();

        public IQueryable<Spendings> SpendingsRead()
        {
            var date = DateTime.Parse("08/08/2015");
            var result = db.Spending.Where(spending => spending.SpendingsDate == date);

            return result;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}