using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public enum EmployeeTypeEnum { Manager , Cashier, Barista, Waiter}
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double SallaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}
