using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = { "3", "4" };
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            int minSupply = (n+1/2)*(m+1/2);

            Console.WriteLine(minSupply);

            Console.ReadKey(true);            
        }
    }
}
