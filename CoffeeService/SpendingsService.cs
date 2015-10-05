using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CoffeeService.Models;

namespace CoffeeService
{
   public  class SpendingsService
    {
        private CoffeeContext entities;

        public SpendingsService(CoffeeContext entities)
        {
            this.entities = entities;
        }

        public IEnumerable<Spendings> Read()
        {
            return entities.Spendings;
        }

        public void Create(Spendings product)
        {
            var entity = new Spendings();

            entity.Name = product.Name;
            entity.Quantity = product.Quantity;
            entity.Datetime = product.Datetime;
            entity.Price = product.Price;

            entities.Spendings.Add(entity);
            entities.SaveChanges();

            product.ID = entity.ID;
        }

        public void Update(Spendings product)
        {
            var entity = new Spendings();

            entity.Name = product.Name;
            entity.Quantity = product.Quantity;
            entity.Datetime = product.Datetime;
            entity.Price = product.Price;

            entities.Spendings.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(Spendings product)
        {
            var entity = new Spendings();

            entity.ID = product.ID;

            entities.Spendings.Attach(entity);

            entities.Spendings.Remove(entity);

            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }
}
