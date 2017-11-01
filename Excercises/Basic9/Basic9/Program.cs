using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the four number: 30

            Expected Output:
            The average of 10 , 15 , 20 , 30 is: 18
            */

            Console.WriteLine("Input the first number: ");
            double number01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            double number02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the third number: ");
            double number03 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the fourth number: ");
            double number04 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The average of {number01}, {number02}, {number03}, {number04} is {(number01 + number02 + number03 + number04) / 4} ");


            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
