using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lists!

            List<int> numbers = new List<int>();

            numbers.Add(13);
            numbers.Add(4);
            numbers.Add(8);
            numbers.Add(1);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + ", ");
            }

            numbers.RemoveAt(1);

            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
