using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public enum ProductTypeEnum { Coffee , Beverage , Food}
    public class ProductCategory : BaseEntity 
    {
        public ProductTypeEnum ProductType { get; set; }
        public List<Product> Products { get; set; }
    }
}
