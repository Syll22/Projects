using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), 
            and then four times in the next row, with no separation. You should do it two times: Use Console. 
            Write and then use {0}.
            Test Data:
            Enter a digit: 25
            Expected Output:
            25 25 25 25
            25252525
            25 25 25 25
            25252525
            */

            Console.WriteLine("Input the first number to multiply: ");
            int number01 = Convert.ToInt32(Console.ReadLine());

            Draw(number01, " ");
            Draw(number01, "");
            Draw(number01, " ");
            Draw(number01, "");

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }

        static void Draw (int number, string space)
        {
            Console.WriteLine(number + space + number + space + number + space + number + space);
        }
    }
}
