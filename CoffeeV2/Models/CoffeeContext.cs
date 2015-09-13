using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CoffeeV2.Models
{
    public class CoffeeContext : DbContext
    {
        public DbSet<Alkohol> Alkohols { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Spendings> Spending { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Syrop> Syrops { get; set; }
    }
}