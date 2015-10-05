using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using CoffeeService;
using CoffeeService.Models;

namespace CoffeeService.Controllers
{
    public class StockController : Controller
    {
        StockService service = new StockService(new CoffeeContext());// created the service of our controller

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StockRead([DataSourceRequest] DataSourceRequest request)
        {
            return Json(service.Read().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult StockCreate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stock> products)
        {
            var results = new List<Stock>();

            if (products != null && ModelState.IsValid)
            {
                foreach (var product in products)
                {
                    service.Create(product);
                    results.Add(product);
                }
            }

            return Json(results.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult StockUpdate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stock> products)
        {
            if (products != null && ModelState.IsValid)
            {
                foreach (var product in products)
                {
                    service.Update(product);
                }
            }

            return Json(products.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult StockDestroy([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Stock> products)
        {
            if (products.Any())
            {
                foreach (var product in products)
                {
                    service.Destroy(product);
                }
            }

            return Json(products.ToDataSourceResult(request, ModelState));
        }
    }
}


//    CoffeeContext db = new CoffeeContext();

//    public ActionResult StockRead ([DataSourceRequest] DataSourceRequest request)
//    {
//        //var date = DateTime.Parse("08/08/2015");
//       // var result = db.Stock.Where(stock => stock.Datetime == date);
//       // return result;

//    IQueryable<Stock> stock = db.Stock;
//    DataSourceResult result = stock.ToDataSourceResult(request);
//    return Json(result);
//    }

//    public ActionResult Index()
//    {
//        return View();
//    }
//}