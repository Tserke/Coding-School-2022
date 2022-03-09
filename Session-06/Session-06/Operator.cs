using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Operator
    {
        public Operator()
        {

        }
        public double FindOperation(string firstNumber, string secondNumber, string operation)
        {
            
            switch (operation)
            {
                case "+":
                    return Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber);
                case "-":
                    return Convert.ToDouble(firstNumber)-Convert.ToDouble(secondNumber);
                case "X":
                    return Convert.ToDouble(firstNumber)*Convert.ToDouble(secondNumber);
                case "/":
                    return Convert.ToDouble(firstNumber)/Convert.ToDouble(secondNumber);
                case "Pow":
                    return Math.Pow(Convert.ToDouble(firstNumber),Convert.ToDouble(secondNumber));
                case "Sqrt":
                    return Convert.ToDouble(firstNumber)*Math.Sqrt(Convert.ToDouble(secondNumber));
                default:
                    return 0;

            }
           
        }
    }
}
