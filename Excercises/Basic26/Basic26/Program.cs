using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# program to compute the sum of the first 500 prime numbers.
            Sample Output:
            Sum of the first 500 prime numbers:
            3682913 
            */

            long sum = 0;
            int counter = 0;
            int n = 0;

            while (counter < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    counter++;
                    Console.WriteLine(n);
                }
                n++;
            }

            Console.WriteLine(sum);


            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }

        static bool isPrime(int checkedNumber)
        {
            if (checkedNumber == 1) return false;
            if (checkedNumber == 2) return true;
            if (checkedNumber % 2 == 0) return false;

            int testLimit = (int)Math.Floor(Math.Sqrt(checkedNumber));

            for (int i = 3; i <= testLimit; i+=2)
            {
                if (checkedNumber % i == 0)
                    return false;
            }

            return true;
        }
            
    }
}
