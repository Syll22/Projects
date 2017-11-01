using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. 
            Go to the editor
            Test Data:
            Input the first number to multiply: 2
            Input the second number to multiply: 3
            Input the third number to multiply: 6
            Expected Output:
            2 x 3 x 6 = 36
             */

            Console.WriteLine("Input the first number to multiply: ");
            int number01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number to multiply: ");
            int number02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the third number to multiply: ");
            int number03 = Convert.ToInt32(Console.ReadLine());

            long result = number01 * number02 * number03;

            Console.WriteLine($"The result is: {result.ToString()}.");

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
