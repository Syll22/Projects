using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to swap two numbers. 
            Test Data:
            Input the First Number : 5
            Input the Second Number : 6 */

            int number01 = 5;
            int number02 = 6;

            Console.WriteLine($"Before switch: number 1 is - {number01} and number 2 is - {number02}");
            Console.WriteLine();

            int auxNumber = number01;
            number01 = number02;
            number02 = auxNumber;

            Console.WriteLine($"After the switch: number 1 is - {number01} and number 2 is - {number02} ");

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
