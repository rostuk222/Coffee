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
        public int SpendingsName{ get; set; }
        public int SpendingsQuantity { get; set; }
        public int SpendingsPrice { get; set; }
    }
}