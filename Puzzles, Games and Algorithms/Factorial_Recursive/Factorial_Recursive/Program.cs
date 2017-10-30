using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the nth value as integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Recursion calculation: Factorial of {n} is {CalculateLoop(n)}");

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }

        private static int CalculateLoop(int n)
        {
            if (n == 1)
                return 1;
            return n * CalculateLoop(n - 1);
        }
    }
}
