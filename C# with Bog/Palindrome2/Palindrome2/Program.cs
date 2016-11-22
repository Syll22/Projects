using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the string you want to be checked: ");
            string stringToCheck = Console.ReadLine();

            char[] arrayToCheck = new char[stringToCheck.Length];
            char[] reversedArray = new char[stringToCheck.Length];

            arrayToCheck = stringToCheck.ToArray();

            int reverseCounter = stringToCheck.Length - 1;
            int indexCounter = 0;

            foreach (char c in arrayToCheck)
            {
                reversedArray[reverseCounter] = arrayToCheck[indexCounter];
                indexCounter++;
                reverseCounter--;
            }

            bool isPalindrom = true;

            for (int i = 0; i < arrayToCheck.Length; i++)
            {
                if (arrayToCheck[i] == reversedArray[i])
                {
                    continue;
                }
                else
                {
                    isPalindrom = false;
                }
            }
                  
            if (isPalindrom)
            {
                Console.WriteLine("Palindrome!");
            }
            else
            {
                Console.WriteLine("Not!");
            }

            Console.ReadKey(true);

        }
    }
}
       