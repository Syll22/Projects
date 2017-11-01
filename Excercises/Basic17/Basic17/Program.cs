using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# program to create a new string from a given string (length 1 or more ) 
            with the first character added at the front and back.
            Sample Output:
            Input a string : The quick brown fox jumps over the lazy dog.
            TThe quick brown fox jumps over the lazy dog.T
            */

            Console.Write("Enter your string: ");
            string input = Console.ReadLine();

            if (input.Length >= 1)
            {
                var substring = input.Substring(0, 1);
                Console.WriteLine(substring + input + substring);
            }


            // Wait for use to ackowledge the results.
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
