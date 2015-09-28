using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeV2.Models;
using System.Data.Entity;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace CoffeeV2.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock

        CoffeeContext db = new CoffeeContext();

        public ActionResult StockRead ([DataSourceRequest] DataSourceRequest request)
        {
            //var date = DateTime.Parse("08/08/2015");
           // var result = db.Stock.Where(stock => stock.Datetime == date);
           // return result;

        IQueryable<Stock> stock = db.Stock;
        DataSourceResult result = stock.ToDataSourceResult(request);
        return Json(result);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}