using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01 = 0;
            int num02 = 0;
            int result = 0;

            Console.WriteLine("Welcome to Math Quiz 2000!");

            Console.Write("\nWrite the first number: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write the second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Start:
            Console.Write("\nWhat is {0} times {1}: ", num01, num02);
            result = Convert.ToInt32(Console.ReadLine());

            if (result == num01*num02)
            {
                Console.WriteLine("\nCorrect!");
            }
            else
            {
                Console.WriteLine("\nTry again!");
                goto Start;
            }

            Console.ReadLine();

        }
    }
}
