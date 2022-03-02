using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex.1
            Console.WriteLine("EXERCISE 1:");
            Console.WriteLine("Hello Tserke\n");

            //ex2.
            int div, sum, num1 = 5, num2 = 5;
            div = num1 / num2;
            sum = num1 + num2;
            Console.WriteLine("EXERSICE 2:");
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum +
                " meanwhile the div of the same numbers is " + div + "\n");

            //ex.3
            short dot1, dot2;
            double dot3, dot4, dot5;

            dot1 = -1 + 5 * 6;
            Console.WriteLine("EXERSICE 3.1");
            Console.WriteLine("-1 + 5 * 6 = " + dot1 + "\n");

            dot2 = 38 + 5 % 7;
            Console.WriteLine("EXERSICE 3.2");
            Console.WriteLine("38 + 5 % 7" + dot2 + "\n");

            dot3 = 14.0 + ((-3.0 * 6.0) / 7.0);
            Console.WriteLine("EXERSICE 3.3");
            Console.WriteLine("14.0 + ((-3.0 * 6.0) / 7.0) = " + dot3 + "\n");

            dot4 = 2.0 + (13.0 / 6.0 * 6.0) + Math.Sqrt(7);
            Console.WriteLine("EXERSICE 3.4");
            Console.WriteLine("2.0 + (13.0 / 6.0 * 6.0) + Sqrt(7) = " + dot4 + "\n");

            dot5 = Math.Pow(6.0, 4.0) + Math.Pow(5.0, 7.0) / 9.0 % 4.0;
            Console.WriteLine("EXERSICE 3.5");
            Console.WriteLine("6^4 + 5^7 / 9mod4 = " + dot5 + "\n");

            //ex.4
            string gender;
            short age;
            Console.WriteLine("EXERCISE 4");
            Console.WriteLine("Please share with me your gender");
            gender = Console.ReadLine();
            Console.WriteLine("Please share with me your age");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You are a " + gender + " and you look younger than " + age + "\n");
            //edw thumamai pws eixate pei na mhn xrisimopoiisoime to convert alla epeidi kai parakatw oi askiseis lene eisodo apo xristi tha eskaga ean den to ekana etsi

            //ex.5

            long sec, min, hours, days, years;
            Console.WriteLine("EXERSICE 5");
            Console.WriteLine("Please enter seconds :");
            sec = Convert.ToInt64(Console.ReadLine());
            min = sec / 60;
            hours = min / 60;
            days = hours / 24;
            years = days / 365;
            Console.WriteLine(" "+sec + " sec : \n-in years: " + years + "\n-in days: " + days + "\n-in hours: " + hours + "\n-in min: " + min + "\n");

            //ex.6
            Console.WriteLine("EXERSICE 6");
            TimeSpan t = TimeSpan.FromSeconds(sec);
            string day = string.Format("{0:d2}d",
            t.Minutes);
            Console.WriteLine("days: " + day);
            string hour = string.Format("{0:d2}h",
            t.Minutes);
            Console.WriteLine("hours: " + hour);
            string minu = string.Format("{0:d2}m",
            t.Minutes);
            Console.WriteLine("min: "+minu);
           

            //ex.7
            double celcius,kelvin,fahrenheit;
            Console.WriteLine("EXERSICE 7");
            Console.WriteLine("please enter the temperature in Celcius: ");
            celcius = Convert.ToDouble(Console.ReadLine());
            kelvin = celcius + 273.15;
            fahrenheit = (celcius * 1.8) + 32;
            Console.WriteLine(celcius + " Celcius are " + kelvin + " Kelvin are " + fahrenheit + " Fahrenheit");
            


            Console.ReadLine();
        }
    }
}
