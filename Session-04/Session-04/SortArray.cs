using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class SortArray
    {
        public SortArray()
        {

        }

        int[] Array = new int[10] {0,-2,1,20,-31,50,-4,17,89,100};

        public void SortingArray()
        {
            int temp = 0;
            for (int i = 0; i < Array.Length - 1; i++)
            {

                for (int j = i + 1; j < Array.Length; j++)
                {

                    if (Array[i] > Array[j])
                    {

                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
        
    }
}
