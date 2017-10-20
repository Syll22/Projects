using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Transformarea din bază 10 în bază 16
namespace LAB4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int baza_zece = 0;
            int rest ;
            Console.WriteLine("Dati un numar in baza 10:");
            baza_zece = int.Parse(Console.ReadLine());
            rest = baza_zece;
            Console.WriteLine("Char: {0}", rest);
                      
            rest = (baza_zece % 16);

            if(rest > 0)
            {
                baza_zece = rest;
                Console.WriteLine("rest = {0}", rest);
             
            }
            
                Console.WriteLine("Gata");
                Console.Read();
            
        }
    }
}
