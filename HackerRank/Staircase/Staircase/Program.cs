using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1 ; i <= n; i++)
            {
                Console.WriteLine(Space(n-i) + Pound(n-(n-i)));
            }
            
            Console.ReadKey(true);
        }

        static string Space (int a)
        {
            string s = "";
            for (int i = 1; i <= a; i++)
            {
                s = s + " ";
            }
            return s;
        }

        static string Pound (int b)
        {
            string t = "";
            for (int i = 1; i <= b; i++)
            {
                t = t + "#";
            }
            return t;
        }
    }
}
