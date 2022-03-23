using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public class TransactionLine
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }  
        public double Discount { get; set; }
        public double TotalPrice { get; set; }
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public Product Product { get; set; }
    }
}
