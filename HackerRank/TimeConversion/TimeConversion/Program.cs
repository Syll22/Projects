using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            int hours = Convert.ToInt32(time.Substring(0, 2));

            if (time[8] == 'P' && hours != 12)
            {
                hours += 12;
                Console.WriteLine(hours + time.Substring(2, 6));
            }
            else if (hours == 12 && time[8] == 'A')
                Console.WriteLine("00" + time.Substring(2, 6));
            else
                Console.WriteLine(time.Substring(0, 8));

            Console.ReadKey(true);
            
        }
    }
}
