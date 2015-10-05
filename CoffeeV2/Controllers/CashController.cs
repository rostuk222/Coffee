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
    public class CashController : Controller
    {
        CashService service = new CashService(new CoffeeContext());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CashRead([DataSourceRequest] DataSourceRequest request)
        {
            return Json(service.Read().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CashCreate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Cash> products)
        {
            var results = new List<Cash>();

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
        public ActionResult CashUpdate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Cash> products)
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
        public ActionResult CashDestroy([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Cash> products)
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