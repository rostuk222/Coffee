using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CoffeeV2.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace CoffeeV2.Controllers
{
    public class CashController : Controller
    {
        // GET: Cash
             CoffeeContext db = new CoffeeContext();

             public ActionResult CashRead ([DataSourceRequest] DataSourceRequest request)
        {
          //  var date = DateTime.Parse("08/08/2015");
           // var result = db.Cash.Where(cash => cash.Datetime == date);
           // return result;
         
            IQueryable<Cash> cash = db.Cash;
            DataSourceResult result = cash.ToDataSourceResult(request);
            return Json(result);
          
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}