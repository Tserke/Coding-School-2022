using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class MockEmployeeRepo : IEntityRepo<Employee>
    {
        private List<Employee> _employees= new List<Employee> { new Employee() { Id=1},new Employee() { Id=2} };
        public async Task Create(Employee entity)
        {
            var context = new CoffeeShopContext();
            context.Employees.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var context = new CoffeeShopContext();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.Id == id);
            if (foundEmployee is null)
                return;

            context.Employees.Remove(foundEmployee);
            await context.SaveChangesAsync();
        }

        public List<Employee> GetAll()
        {
            var context = new CoffeeShopContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            var context = new CoffeeShopContext();
            return context.Employees.Where(employe => employe.Id == id).SingleOrDefault();
        }

        public async Task Update(int id, Employee entity)
        {
            var context = new CoffeeShopContext();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.Id == id);
            if (foundEmployee is null)
                return;

            foundEmployee.EmployeeType = entity.EmployeeType;
            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.SallaryPerMonth = entity.SallaryPerMonth;
            await context.SaveChangesAsync();
        }
    }
}
