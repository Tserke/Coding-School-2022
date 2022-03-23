using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public async Task Create(TransactionLine entity)
        {
            var context = new CoffeeShopContext();
            context.TransactionLines.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var context = new CoffeeShopContext();
            var foundLine=context.TransactionLines.SingleOrDefault(line => line.Id == id);
            if (foundLine is null)
                return;

            context.TransactionLines.Remove(foundLine);
            await context.SaveChangesAsync();
        }

        public List<TransactionLine> GetAll()
        {
            var context = new CoffeeShopContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(int id)
        {
            var context = new CoffeeShopContext();
            return context.TransactionLines.Where(line => line.Id == id).SingleOrDefault();
        }

        public async Task Update(int id, TransactionLine entity)
        {
            var context = new CoffeeShopContext();
            var foundLine = context.TransactionLines.SingleOrDefault(line => line.Id == id);
            if (foundLine is null)
                return;

            foundLine.ProductId = entity.Product.Id;
            foundLine.Quantity = entity.Quantity;
            foundLine.Price = entity.Price;
            foundLine.Discount = entity.Discount;
            foundLine.TotalPrice = entity.TotalPrice;

            await context.SaveChangesAsync();
        }
    }
}
