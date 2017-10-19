using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Classes
{
    class Animal
    {
        // This is a property or field. Beeing static it is attached to the Animal class and not to the objects created from the class.
        // It is used calling Animal.Count instead of dog.Count
        public static int Count = 0; 

        public string name;
        public int age;
        public float happiness;

        //This is a constructor of the class Animal. It looks like "ClassName" followed by () and {}
        public Animal () 
        {
            name = "Spotty";
            age = 6;
            happiness = 0.5f;
            Count++;
        }

        //This is another constructor. It is different from the first one because it has 3 arguments
        public Animal(string _name, int _age, float _happiness) 
        {
            name = _name;
            age = _age;
            happiness = _happiness;
            Count++;
        }

        public void Print() //This is a method of the class Animal that is called using name.print (name of the animal)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // This is how Classes
            Animal dog = new Animal();
            dog.Print();

            Console.WriteLine();

            Animal cat = new Animal("Mr. Beans", 10, 0.8f);
            cat.Print();

            Console.WriteLine();
            Console.WriteLine("Number of animals: " + Animal.Count);
            
            Console.ReadKey();
        }
    }
}
