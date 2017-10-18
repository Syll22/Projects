using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(4, 8);
            if (result > 10)
            {
                Console.WriteLine("Result is greater than 10!");
            }
            else
            {
                Console.WriteLine("Result is lesser or equal to 10!");
            }
            Console.ReadLine();
        }

        public static int Add(int num01, int num02)
        {
            return num01 + num02;
        }
    }
}
