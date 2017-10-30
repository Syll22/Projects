using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the nth value as integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            CalculateLoop(n);

            Console.WriteLine($"Loop calculation: Factorial of {n} is {CalculateLoop(n)}");
            Console.WriteLine();
            Console.WriteLine($"Loop calculation 2: Factorial of {n} is {CalculateLoop2(n)}");


            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }

        private static int CalculateLoop(int n)
        {
            int factorial = 1;
            for (int i = n; i >=1; i-- )
            {
                factorial *= i;
            }
            return factorial;
        }

        private static int CalculateLoop2(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
