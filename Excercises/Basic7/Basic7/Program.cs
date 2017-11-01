using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers 
            which will be entered by the user. 
            Test Data:
            Input the first number: 25
            Input the second number: 4
            Expected Output:
            25 + 4 = 29
            25 - 4 = 21
            25 x 4 = 100
            25 / 4 = 6
            25 mod 4 = 1
            */

            Console.WriteLine("Input the first number: ");
            double number01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            double number02 = Convert.ToInt32(Console.ReadLine());

            double resultAdd = number01 + number02;
            double resultSubs = number01 - number02;
            double resultMult = number01 * number02;
            double resultDivide = number01 / number02;

            Console.WriteLine();

            Console.WriteLine($"{number01} + {number02} = {resultAdd}.");
            Console.WriteLine($"{number01} - {number02} = {resultSubs}.");
            Console.WriteLine($"{number01} x {number02} = {resultMult}.");
            Console.WriteLine($"{number01} / {number02} = {resultDivide}.");

            Console.WriteLine();

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
