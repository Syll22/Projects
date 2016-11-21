using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                StaticPropertyExample spe = new StaticPropertyExample();

                StaticPropertyExample.Add(1, 2);
                Console.WriteLine("nonstatic: " + spe.ExposedPrivateField);
                Console.WriteLine("static: " + spe.ExposedStaticField);
            }

            Color white = Color.FromString("white");
            Color red = Color.FromString("red");
            
            white.Blue = 255;
            white.Green = 255;

            Console.ReadKey(true);
        }
    }


    class StaticPropertyExample
    {
        public StaticPropertyExample()
        {
            myPrivateField++;
            myStaticField++;
        }

        private int myPrivateField =0;

        private static int myStaticField = 0;


        public int ExposedStaticField
        {
            get
            {
                return myStaticField;
            }
        }

        public int ExposedPrivateField
        {
            get
            {
                return myPrivateField;
            }
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }

    }

    class Color
    {
        public Color(int r, int g, int b)
        {
            Red = r;
            Green = g;
            Blue = b;


        }
        public int Red { get; private set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public static Color FromString(string colorName)
        {
            if (colorName == "white")
            {
                return new Color(255, 255, 255);
            }
            else if (colorName == "red")
            {
                return new Color(255, 0, 0);
            }

            return null;

        }


        
    }


    class Emp
    {
        int salariu;

        private static double CAS(Emp dude)
        {
            return dude.salariu * 0.245;
        }

        public Emp(int salar)
        {
            salar = salariu;
            double contributie = CAS(this);
        }
        
    }

}
