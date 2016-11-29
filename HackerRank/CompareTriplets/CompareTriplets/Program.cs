using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int pointAlice = 0;
            int pointBob = 0;

            for (int i = 0; i < tokens_a0.Length; i++)
            {
                if (int.Parse(tokens_a0[i]) > int.Parse(tokens_b0[i]))
                    pointAlice++;
                else if (int.Parse(tokens_a0[i]) < int.Parse(tokens_b0[i]))
                    pointBob++;
            }
            Console.WriteLine(pointAlice + " " + pointBob);
        }
    }
}
