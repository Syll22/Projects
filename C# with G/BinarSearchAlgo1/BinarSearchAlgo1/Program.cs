using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarSearchAlgo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int x = 9;

            int result = search(arr, x);

            if (result == -1)
                Console.WriteLine("The element was not found.");
            else
                Console.WriteLine("The element is at position {0}.", arr.ToList().IndexOf(result));

            Console.ReadKey();
        }

        static int search(int[] array, int searched)
        {
            if (array.Length > 1)
            {
                if (array[array.Length / 2] == searched)
                    return array[array.Length / 2];
                else if (array[array.Length / 2] > searched)
                {
                    array = array.Take(array.Length / 2).ToArray();
                    return search(array, searched);
                }
                else if (array[array.Length / 2] < searched)
                {
                    array = array.Skip(array.Length / 2).ToArray();
                    return search(array, searched);
                }
            }
            return -1;
        }
    }
}
