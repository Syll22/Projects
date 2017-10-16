using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FirstConsoleProject
{
    class Program
    {
        static void Main(string[] args)  //this is a method called "Main". It is called when the program starts.
        {
            Start:
            int num01;
            int num02;

            Console.Write ("Type a number to be multiplied: ");
            num01 = Convert.ToInt32 (Console.ReadLine ());

            Console.Write("Type another number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("This number {0} multiplied by this number {1} equals: {2} ",num01,num02,num01 * num02);

            Console.ReadLine();

            goto Start;
        }
    }
}
