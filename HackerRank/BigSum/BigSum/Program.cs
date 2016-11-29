using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int sumD1 = 0;
            int sumD2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumD1 = sumD1 + a[i][i];
                sumD2 = sumD2 + a[i][n - 1 - i];
            }

            int sumDiff = Math.Abs(sumD1 - sumD2);

            Console.WriteLine(sumDiff);

            Console.ReadKey(true);
        }
    }
}
