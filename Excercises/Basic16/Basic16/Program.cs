using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            Test Data:
            w3resource
            Python
            Sample Output:
            e3resourcw
            nythoP 
            */

            Console.WriteLine(Swap("w3resource"));
            Console.WriteLine(Swap("Python"));
            Console.WriteLine(Swap("x"));

            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }

        static string Swap (string input)
        {
            return input.Length > 1 ? input.Substring(input.Length - 1) + input.Substring(1, input.Length - 2) + input.Substring(0, 1) : input;
        }
    }
}
