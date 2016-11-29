using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int plusCounter = 0;
            int minusCounter = 0;
            int zeroCounter = 0;

            for (int i =0; i <n; i++)
            {
                if (arr[i] > 0)
                    plusCounter++;
                else if (arr[i] < 0)
                    minusCounter++;
                else
                    zeroCounter++;
            }

            double plus = (double) plusCounter / n;
            double minus = (double) minusCounter / n;
            double zero = (double) zeroCounter / n;

            Console.WriteLine(plus + "\n" + minus + "\n" + zero);

            Console.ReadKey(true);

        }
    }
}
