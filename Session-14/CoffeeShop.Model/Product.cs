using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public class Product : BaseEntity
    {
        public int ProductCategoryId { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public TransactionLine TransactionLine { get; set; }

    }
}
