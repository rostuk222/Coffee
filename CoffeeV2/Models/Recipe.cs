using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoffeeV2.Models
{
    public partial class Cash
    {
        public DateTime Date { get; set; }
        public decimal Costs { get; set; }
        public decimal Income { get; set; }
        public decimal Cashless { get; set; }
        public decimal Result { get; set; }
    }
}