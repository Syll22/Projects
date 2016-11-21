using System;

namespace My_First_Example_App
{
    class Program
    {
        static void Main(string [] args)
        {
            string [] operanzii = new string [] { "+", "-", "*", "/" };
            string operatie = string.Empty; //12 + 3

            Console.WriteLine("Instantiem clasa Calculator");
            Calculator myCalculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Intordu operatia");
                operatie = Console.ReadLine();

                string [] split = operatie.Split(operanzii, StringSplitOptions.RemoveEmptyEntries);

                myCalculator.primulOperad = int.Parse(split [0]);
                myCalculator.alDoileaOperand = int.Parse(split [1]);

                for (int i = 0; i < operanzii.Length; i++)
                {
                    if (operatie.Contains(operanzii [i]))
                    {
                        myCalculator.Operatie(operanzii [i]);
                    }
                }
            }
        }
    }
}