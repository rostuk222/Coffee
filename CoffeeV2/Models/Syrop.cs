using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoffeeV2.Models
{
    public partial class Syrop
    {
        public int ID { get; set; }
        public string SyropName { get; set; }
        public DateTime Date { get; set; }
        public int SyropQuantity { get; set; }
    }
}