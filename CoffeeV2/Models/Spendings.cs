using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoffeeV2.Models
{
    public partial class Spendings
    {
        public int ID { get; set; }
        public DateTime SpendingsDate {get; set;}
        public int CoffeeSpendings { get; set; }
        public int MilkSpendings { get; set; }
        public int WaterSpendings { get; set; }
        public int SpendingsSyropID { get; set; }
        public int SyropQuantitySpendings { get; set; }
        public int SpendingsAlkoholID { get; set; }
        public int AlkoholQuantitySpendings { get; set; }

    }
}