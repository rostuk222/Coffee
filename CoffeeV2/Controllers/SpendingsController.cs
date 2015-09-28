using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CoffeeV2.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace CoffeeV2.Controllers
{
    public class SpendingsController : Controller
    {
        // GET: Spendings

        CoffeeContext db = new CoffeeContext();

        public ActionResult SpendingsRead ([DataSourceRequest] DataSourceRequest request)
        {
          //  var date = DateTime.Parse("08/08/2015");
          //  var result = db.Spendings.Where(spending => spending.Datetime == date);
         //   return result;

            IQueryable<Spendings> spending = db.Spendings;
            DataSourceResult result = spending.ToDataSourceResult(request);
            return Json(result);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}