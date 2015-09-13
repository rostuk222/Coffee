using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoffeeV2.Models
{
    public class CoffeeDbInitializer : DropCreateDatabaseAlways <CoffeeContext>
    {
        protected override void Seed(CoffeeContext db)
        {
            db.Alkohols.Add(new Alkohol{ID = 1, AlkoholName = "Коньяк", AlkoQuantity = 35, Date = DateTime.Now.Date});
            db.Alkohols.Add(new Alkohol { ID = 2, AlkoholName = "Ром", AlkoQuantity = 30, Date = DateTime.Now.Date });
            db.Alkohols.Add(new Alkohol { ID = 3, AlkoholName = "Віскі", AlkoQuantity = 20, Date = DateTime.Now.Date });
            db.Alkohols.Add(new Alkohol { ID = 4, AlkoholName = "Вана Таллін", AlkoQuantity = 15, Date = DateTime.Now.Date });
            db.Alkohols.Add(new Alkohol { ID = 5, AlkoholName = "Бейліз", AlkoQuantity = 25, Date = DateTime.Now.Date});

            db.Syrops.Add(new Syrop { ID = 1, SyropName = "Шоколад", SyropQuantity = 25, Date = DateTime.Now.Date});
            db.Syrops.Add(new Syrop { ID = 2, SyropName = "Карамель", SyropQuantity = 60, Date = DateTime.Now.Date });
            db.Syrops.Add(new Syrop { ID = 3, SyropName = "Ваніль", SyropQuantity = 10, Date = DateTime.Now.Date });
            db.Syrops.Add(new Syrop { ID = 4, SyropName = "Горіх", SyropQuantity = 20, Date = DateTime.Now.Date });
            db.Syrops.Add(new Syrop { ID = 5, SyropName = "Кокос", SyropQuantity = 30, Date = DateTime.Now.Date });
            db.Syrops.Add(new Syrop { ID = 6, SyropName = "Вишня", SyropQuantity = 15, Date = DateTime.Now.Date});
            db.Syrops.Add(new Syrop { ID = 7, SyropName = "Амаретто", SyropQuantity = 45, Date = DateTime.Now.Date });
            db.Syrops.Add(new Syrop { ID = 8, SyropName = "Тірамісу", SyropQuantity = 55, Date = DateTime.Now.Date });
   
            db.Stocks.Add (new Stock {ID = 1, ItemName = "Кава", Quantity = 700, Date = DateTime.Parse("08-08-2015")});
            db.Stocks.Add(new Stock { ID = 2, ItemName = "Молоко", Quantity = 700, Date = DateTime.Parse("08-08-2015") });
            db.Stocks.Add(new Stock { ID = 3, ItemName = "Вода", Quantity = 700, Date = DateTime.Parse("08-08-2015") });
            base.Seed(db);
        }
    }
}