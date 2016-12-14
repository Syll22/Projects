using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, long.Parse);

            bool smthChanged = false;

            do
            {
                smthChanged = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        smthChanged = true;
                        long j = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = j;
                    }

                }

            }

            while (smthChanged);

            long minSum = arr[0] + arr[1] + arr[2] + arr[3];
            long MaxSum = arr[1] + arr[2] + arr[3] + arr[4];

            Console.WriteLine(minSum + " " + MaxSum);

            Console.ReadKey(true);

        }
    }
}
