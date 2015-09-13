using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoffeeV2.Models
{
    public partial class Orders
    {
        public DateTime OrderDate { get; set; }
        public int ID { get; set; }
        public int OrderSize { get; set; }
        public decimal OrderPrice { get; set; }
        public int OrderAmount { get; set; }
        public decimal OrderSum { get; set; }
    }
}