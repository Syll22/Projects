using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program that takes a number as input and print its multiplication table.
            Test Data:
            Enter the number: 5
            Expected Output:
            5 * 0 = 0
            5 * 1 = 5
            5 * 2 = 10
            5 * 3 = 15
            ....
            5 * 10 = 50 */

            Console.Write("Enter the number: ");
            int number01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number01} * {i} = {number01 * i}");
            }

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
