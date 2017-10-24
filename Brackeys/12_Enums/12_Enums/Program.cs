using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Enums
{
    class Program
    {
        // Base class
        class Animal
        {
            public string name;
            public int age;
            public float happiness;
        }

        // Derived class
        class Dog : Animal
        {
            public int breed;

            public Dog (string _name, int _age, float _happiness, int _breed)
            {
                name = _name;
                age = _age;
                happiness = _happiness;
                breed = _breed;
            }

            public void Print() // Prints details about the dog to the console
            {
                Console.WriteLine("Name: {0}\nAge: {1}\nHappiness: {2}" + name,age,happiness);

                switch (breed)
                {

                    default:
                        break;
                }
            }
        }

        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
