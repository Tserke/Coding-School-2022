using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ex.1
            Console.WriteLine("ex.1");
            string name = "Dimitris Tserkezidis";
            var reverse = new Reverse();
            string reversedName = reverse.ReverseStringFor(name);
            Console.WriteLine(reversedName);

            //ex.2
            Console.WriteLine("\nex.1");
            int number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            var sum = new Sum();
            Console.WriteLine(sum.SumNumbers(number));
            var product = new Product();
            Console.WriteLine(product.ProductNumbers(number));

            //ex.3
            Console.WriteLine("\nex.3");
            int n;
            Console.WriteLine("enter a number to find Primes");
            n = Convert.ToInt32(Console.ReadLine());
            var prime = new Prime();
            prime.showPrime(n);

            //ex.4
            Console.WriteLine("\nex.4");
            var arrayMultiplication = new ArrayMultiplication();
            arrayMultiplication.MultiplyArrays();

            //ex.5
            Console.WriteLine("\nex.5");
            var sortArray= new SortArray();
            sortArray.SortingArray();
                             

            Console.ReadLine();
        }
    }
}
