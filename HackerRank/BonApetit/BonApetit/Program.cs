using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonApetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(nk_temp, Int32.Parse);

            int n = arr[0];
            int k = arr[1];

            nk_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(nk_temp, Int32.Parse);

            int b = Convert.ToInt32(Console.ReadLine());

            int sumCosts = 0;

            for (int i = 0; i < c.Length; i++)
                sumCosts += c[i];

            int costRachel = (sumCosts - c[k]) / 2;

            if (costRachel == b)
                Console.WriteLine("Bon Apetit");
            else
                Console.WriteLine(b - costRachel);

        }
    }
}
