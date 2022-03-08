using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Validation
    {

        public Validation()
        {

        }

        string numTest;
        char[] inputArray;
        public bool IsNumber(string input)
        {
                bool isNumber = false;
                inputArray = input.ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                numTest = Convert.ToString(inputArray[i]);
                if ( numTest == "0" || numTest == "1" || numTest == "2" || numTest == "3" || numTest == "4" || numTest == "5" || numTest == "6" || numTest == "7" || numTest == "8" || numTest == "9")
                {
                    isNumber = true;
                }
                else { isNumber = false; }
            }
            return isNumber;
        }

    }


}

