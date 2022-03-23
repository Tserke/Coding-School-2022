using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{   
    public enum PaymentMethodEnum { Cash, Cart }
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public double TotalPrice { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public int TransacionLineId { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }

    }
}
