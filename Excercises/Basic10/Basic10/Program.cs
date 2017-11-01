using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y)*z and x*y + y*z
            Test Data:
            Enter first number: 5
            Enter second number: 6
            Enter third number: 7

            Expected Output:
            Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
            */

            Console.WriteLine("Input the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the first number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the first number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y)*z is {(x + y) * z} and x*y+y*z is {x * y + y * z}");

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
