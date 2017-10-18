using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays!

            int[] numbers = new int[5];
            numbers[0] = 12;
            numbers[1] = 3;
            numbers[2] = 5;

            //Looping through the array

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }

            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }

            string[] names = new string[3] { "Thom", "Mark", "Matt" };

            Console.WriteLine();
            Console.WriteLine(names[1]);

            Console.ReadKey();
        }
    }
}
