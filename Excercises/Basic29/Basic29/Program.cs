using System;
using System.IO;

namespace Basic29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# program to find the size of a specified file in bytes.
            Sample Output:
            Size of a file: 31 
            */

            FileInfo f = new FileInfo(@"C:\Users\sserigeanu\Desktop\Oferta.txt");
            Console.WriteLine("\nSize of the file: " + f.Length.ToString());

            // Wait for use to ackowledge the results.
            Console.WriteLine("\nPress any key to close the console...");
            Console.ReadKey();
        }
    }
}
