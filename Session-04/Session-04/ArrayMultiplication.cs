using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ArrayMultiplication
    {

        public ArrayMultiplication()
        {

        }

        int[] Array1 = new int[4] { 2, 4, 9, 12 };
        int[] Array2 = new int[4] { 1, 3, 7, 10 };
        int[] Array3 = new int[16];

        public void MultiplyArrays()
        {
            int product = 0;
            int count = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    product = Array1[i] * Array2[j];
                    Array3[count++] = product;
                    Console.WriteLine(Array3[count - 1]);
                }
            }
        }
    }
}
