using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interfaces
{
    class Program
    {
        interface IItem
        {
            string name { get; set; }
            int goldValue { get; set; }

            void Equip();
            void Sell();
        }

        interface IDamageble
        {
            int durability { get; set; }

            void TakeDamage(int _amount);
        }

        interface IPartOfQuest
        {
            void TurnIn();
        }

        class Sword : IItem, IDamageble, IPartOfQuest
        {
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Sword (string _name)
            {
                name = _name;
                goldValue = 100;
                durability = 50;
            }

            public void Equip()
            {
                Console.WriteLine(name + " equipped.");
            }

            public void Sell()
            {
                Console.WriteLine(name + "sold for " + goldValue + "coins.");
            }

            public void TakeDamage (int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine(name + " damaged by " + _dmg + ". It now has {0} durability.", durability);
            }

            public void TurnIn()
            {
                Console.WriteLine(name + " turned in.");
            }
        }

        class Axe : IItem, IDamageble
        {
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Axe(string _name)
            {
                name = _name;
                goldValue = 100;
                durability = 50;
            }

            public void Equip()
            {
                Console.WriteLine(name + " equipped.");
            }

            public void Sell()
            {
                Console.WriteLine(name + "sold for " + goldValue + "coins.");
            }

            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine(name + " damaged by " + _dmg + ". It now has {0} durability.", durability);
            }
        }

        static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of Destiny");
            sword.Equip();
            sword.TakeDamage(10);
            sword.Sell();
            sword.TurnIn();

            Console.WriteLine();

            Axe axe = new Axe("Axe of Fury");
            axe.Equip();
            axe.TakeDamage(20);
            axe.Sell();

            Console.ReadKey();
        }
    }
}
