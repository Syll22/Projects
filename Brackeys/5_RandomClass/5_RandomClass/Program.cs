using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random(); //this is how an instance of class Random is created. The instance name is numberGenerator

            int num01 = numberGenerator.Next(1, 11);
            int num02 = numberGenerator.Next(1, 11);

            Start:
            Console.Write("\nWhat is {0} times {1}: ", num01, num02);
            int result = Convert.ToInt32(Console.ReadLine());

            if (result == num01 * num02)
            {
                Console.WriteLine("\nCorrect!");
            }
            else
            {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("\nAre you even trying?");
                        break;
                    case 2:
                        Console.WriteLine("\nIncorrect");
                        break;
                    default:
                        Console.WriteLine("\nTry again!");
                        break;
                }

                goto Start;
            }

            Console.ReadLine();
        }
    }
}
