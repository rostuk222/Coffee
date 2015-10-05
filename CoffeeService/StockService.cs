using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CoffeeService.Models;

namespace CoffeeService
{
   public class StockService
    {
        private CoffeeContext entities;

        public StockService(CoffeeContext entities)
        {
            this.entities = entities;
        }

        public IEnumerable<Stock> Read()
        {
            return entities.Stock;
        }

        public void Create(Stock product)
        {
            var entity = new Stock();

            entity.Name = product.Name;
            entity.Quantity = product.Quantity;
            entity.Datetime = product.Datetime;

            entities.Stock.Add(entity);
            entities.SaveChanges();

            product.ID= entity.ID;
        }

        public void Update(Stock product)
        {
            var entity = new Stock();

            entity.Name = product.Name;
            entity.Quantity = product.Quantity;
            entity.Datetime = product.Datetime;

            entities.Stock.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(Stock product)
        {
            var entity = new Stock();

            entity.ID = product.ID;

            entities.Stock.Attach(entity);

            entities.Stock.Remove(entity);

            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }
    }
