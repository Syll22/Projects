using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);
            int counterApples = 0;
            int counterOranges = 0;

            for (int i = 0; i < apple.Length; i++)
                if (apple[i] >= s - a && apple[i] <= t - a)
                    counterApples++;

            for (int i = 0; i < orange.Length; i++)
                if (orange[i] <= t - b && orange[i] >= s - b)
                    counterOranges++;

            Console.WriteLine(counterApples);
            Console.WriteLine(counterOranges);
            
        }
    }
}
