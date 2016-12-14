using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            int[] c = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            Dictionary<int, int> dicSosete = new Dictionary<int, int>();

            foreach(int val in c)
            {
                if (dicSosete.ContainsKey(val))
                    dicSosete[val]++;
                else
                    dicSosete.Add(val, 1);
            }
            int sumPerechi = 0;
            foreach(int key in dicSosete.Keys)         
                sumPerechi += key / 2;

            Console.WriteLine(sumPerechi); 
            
                       
        }
    }
}
