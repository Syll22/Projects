using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# program remove specified a character from a non-empty string using index of a character.
            Test Data:
            w3resource
            Sample Output:
            wresource
            w3resourc
            3resource
            */

            string input = "w3resource";

            Console.WriteLine($"Input: \n{input}");
            Console.WriteLine("\nOutput:");
            Console.WriteLine(input.Remove(1, 1));
            Console.WriteLine(input.Remove(9, 1));
            Console.WriteLine(input.Remove(0, 1));


            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
