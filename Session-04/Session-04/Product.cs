using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Product
    {

        public Product()
        {

        }

        public int ProductNumbers(int number)
        {
            int productNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                productNumber *= i;
            }
            return productNumber;
        }
    }
}
