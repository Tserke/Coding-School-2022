using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Manager
    {

        public Manager()
        {

        }
        bool isZero=false;
        public string Manage(string firstNumber,string secondNumber,string operation)
        {
            if (Convert.ToDouble(secondNumber) == 0.0)
            {
                isZero = true;
            }
            if (isZero == false) 
            { 
            Operator operate = new Operator();
            return (operate.FindOperation(firstNumber, secondNumber, operation).ToString());
            }
            else { 
            return "0";
            }
        }

    }
}
