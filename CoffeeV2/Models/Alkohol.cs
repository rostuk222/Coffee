using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoffeeV2.Models
{
    public partial class Alkohol
    {
        public int ID { get; set; }
        public string AlkoholName { get; set; }
        public DateTime Date { get; set; }
        public int AlkoQuantity { get; set; }
    }
}