using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpSearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
            int searched = 122;
            int jump = Convert.ToInt32(Math.Sqrt(arr.Length));

            int result = JumpSearchAlgorithm(arr, searched, jump);

            if (result == -1)
                Console.WriteLine("The element cannot be found.");
            else
                Console.WriteLine("The element is at position {0}", result);

            Console.ReadKey();
        }

        //m = √n, where n is the size of the array and m is the jump length

        static int JumpSearchAlgorithm (int[] array, int x, int m)
        {
            for (int i = 0; i <= array.Length; i+=m)
            {
                if (array[i]== x)
                    return i;
                else if (array[i] < x)
                    continue;
                else if (array[i] > x)
                {
                    for (int j = i-m+1 ; j < i; j++)
                    {
                        if (array[j] == x)
                            return j;
                        else
                            continue;
                    }
                    return -1;
                }
            }
            return -1;
        }
    }
}
