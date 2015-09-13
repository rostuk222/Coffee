using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoffeeV2.Models
{
    public partial class Recipe
    {
        public int ID { get; set; }
        public string RecipeName { get; set; }
        public int RecipeSize { get; set; }
        public string RecipeAdd { get; set; }
        public int RecipeCoffeeQuantity { get; set; }
        public int RecipeMilkQuantity { get; set; }
        public int RecipeWaterQuantity { get; set; }
        public decimal RecipePrice { get; set; }
        public int SyropID { get; set; }
        public string SyropName { get; set; }
        public int AlkoholID { get; set; }
        public string AlkoholName { get; set; }

    }
}