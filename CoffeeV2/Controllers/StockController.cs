using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeV2.Models;

namespace CoffeeV2.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock

        CoffeeContext db = new CoffeeContext();

        public IQueryable<Stock> StockRead()
        {
            var date = DateTime.Parse("08/08/2015");
            var result = db.Stocks.Where(stock => stock.Date == date);

            return result;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}