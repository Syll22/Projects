using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a C# program to get the absolute value of the difference between two given numbers. 
             Return double the absolute value of the difference if the first number is greater than second number.
            */

            Console.WriteLine("Input the first number: ");
            int number01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the first number: ");
            int number02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result: {Math.Abs(number01-number02)}");

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
