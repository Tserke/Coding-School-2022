using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeShop.EF.Repositories
{
    public class MockTransactionRepo : IEntityRepo<Transaction>
    { 
        private List<Transaction> _transactions=new List<Transaction>() { new Transaction() { Id = 1 }, new Transaction() { Id = 2 } };
    
        public async Task Create(Transaction entity)
        {
            var context = new CoffeeShopContext();
            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var context = new CoffeeShopContext();
            var foundTransaction = context.TransactionLines.SingleOrDefault(transaction => transaction.Id == id);
            if (foundTransaction is null)
                return;

            context.TransactionLines.Remove(foundTransaction);
            await context.SaveChangesAsync();
        }

        public List<Transaction> GetAll()
        {
            var context = new CoffeeShopContext();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(int id)
        {
            var context = new CoffeeShopContext();
            return context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();

        }

        public async Task Update(int id, Transaction entity)
        {
            var context = new CoffeeShopContext();
            var foundTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (foundTransaction is null)
                return;

            foundTransaction.CustomerId = entity.Customer.Id;
            foundTransaction.EmployeeId = entity.Employee.Id;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.TotalPrice = entity.TotalPrice;

            await context.SaveChangesAsync();
        }
    }
}
