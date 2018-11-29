using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchAlgo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };

            int searchElement = 888;
            //bool checker = false;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (searchElement == arr[i])
            //    {
            //        Console.WriteLine(i);
            //        checker = true;
            //        break;
            //    }
            //}

            //if (!checker)
            //{
            //    Console.WriteLine(-1);
            //}

            Console.WriteLine (search(arr, searchElement));

            Console.ReadKey();
        }

        static int search(int[] array, int searched)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (searched==array[i])
                    return i;
            }
            return -1;
        }
    }
}
