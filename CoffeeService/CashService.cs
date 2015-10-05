using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CoffeeService.Models;

namespace CoffeeService
{
    public class CashService
    {
        private CoffeeContext entities;

        public CashService(CoffeeContext entities)
        {
            this.entities = entities;
        }

        public IEnumerable<Cash> Read()
        {
            return entities.Cash;
        }

        public void Create(Cash product)
        {
            var entity = new Cash();

            entity.Datetime= product.Datetime;
            entity.Costs = product.Costs;
            entity.Income = product.Income;
            entity.Cashless = product.Cashless;
            entity.Result = product.Result;

            entities.Cash.Add(entity);
            entities.SaveChanges();

            product.ID = entity.ID;
        }

        public void Update(Cash product)
        {
            var entity = new Cash();
            entity.Datetime = product.Datetime;
            entity.Costs = product.Costs;
            entity.Income = product.Income;
            entity.Cashless = product.Cashless;
            entity.Result = product.Result;

            entities.Cash.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(Cash product)
        {
            var entity = new Cash();

            entity.ID = product.ID;

            entities.Cash.Attach(entity);

            entities.Cash.Remove(entity);

            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }
}
