using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.Write("Enter the string you want to be checked: ");

            string stringToCheck = Console.ReadLine();
            //string reversedString = Invert(stringToCheck);

            if (Compare(stringToCheck))
            {
                Console.WriteLine("\nYour string is a palindrome.");
            }
            else
            {
                Console.WriteLine("\nYour string is not a palindrome.");
            }

            
            Console.ReadKey(true);
        }

        static string Invert(string input)
        {
            char[] stringToInvert = input.ToArray();
            char[] invertedString = stringToInvert.Reverse().ToArray();

            string output = new string(invertedString);

            return output;
        }

        static bool Compare (string s1)
        {
            char[] s12charArray = s1.ToCharArray();
            char[] s2charArray = new char[s12charArray.Length];

            for (int i = s12charArray.Length - 1, j = 0; i > -1; i--)
            {
                s2charArray[j] = s12charArray[i];
                j++;
            }

            for (int i = 0; i < s12charArray.Length-1; i++)
            {
                if (s12charArray[i]==s2charArray[i])
=======
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
>>>>>>> c17444b96f268541ca16e0656ec680a9627e7ba3
                {
                    continue;
                }
                else
                {
<<<<<<< HEAD
                    return false;
                }
            }

            return true;
=======
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
>>>>>>> c17444b96f268541ca16e0656ec680a9627e7ba3

        }
    }
}
