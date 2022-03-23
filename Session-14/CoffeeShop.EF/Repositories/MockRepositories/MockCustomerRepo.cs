using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class MockCustomerRepo : IEntityRepo<Customer>
    {
        private List<Customer> _customers = new List<Customer> { new Customer() { Id=1}, new Customer() { Id=2} } ;
        public async Task Create(Customer entity)
        {
            using var context = new CoffeeShopContext();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            using var context = new CoffeeShopContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            using var context = new CoffeeShopContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(int id)
        {
            using var context = new CoffeeShopContext();
            return context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
        }

        //TODO: Add Functionality
        public async Task Update(int id, Customer entity)
        {
            using var context = new CoffeeShopContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Description = entity.Description;
            foundCustomer.Code = entity.Code;
            await context.SaveChangesAsync();
        }
    }
}
