using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_WHILE_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();

            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt !=6)
            {
                attempt = randomNumberGenerator.Next(1, 7);
                Console.WriteLine("Tom rolled: " + attempt + "."); 
                numberOfAttempts++;
            }

            Console.WriteLine("It took Tom " + numberOfAttempts + " attempts to roll a six.");

            Console.ReadKey();
        }
    }
}
