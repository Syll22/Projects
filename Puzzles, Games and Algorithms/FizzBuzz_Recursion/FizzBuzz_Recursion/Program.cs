using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion solution");

            RecursiveSolution(1);

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }

        private static void RecursiveSolution(int n)
        {
            string text = "";
            if (n > 100)
                return;

            if (n % 15 == 0)
                text = "FizzBuzz";
            else if (n % 3 == 0)
                text = "Fizz";
            else if (n % 5 ==0)
                text = "Buzz";
            else
                text = n.ToString();

            Console.WriteLine(text);
            RecursiveSolution(n + 1);
        }
    }
}
