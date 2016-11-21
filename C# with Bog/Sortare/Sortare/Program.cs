using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortare
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputVectorLength = -1; 

            Console.WriteLine("How long is the vector you want to sort? \n");
            Console.Write("Enter a number greater than 1: ");

            inputVectorLength = GatherIntegerInput(1, Int32.MaxValue);

            Console.WriteLine("\nYour vector will have " + inputVectorLength.ToString() + " elements.\n");

            int[] sortableVector = new int[inputVectorLength];

            Random myRandom = new Random();

            Console.WriteLine("How do you want to generate the vector?");
            Console.WriteLine("1 - Manually");
            Console.WriteLine("2 - Randomly");

            int vectorGenerationMethod = GatherIntegerInput (0,2);
            
            if (vectorGenerationMethod == 1)
            {
                Console.WriteLine("\nYou have selected manual mode.");
                Console.WriteLine("Please enter numbers between 1 and 100.\n");

                for (int i = 0; i < inputVectorLength; i++)
                {

                    int j = i + 1;
                    Console.WriteLine("Please input numbner " + j + "/" + inputVectorLength);

                    sortableVector[i] = GatherIntegerInput(0, 100);

                }

            }

            else if (vectorGenerationMethod == 2)
            {
                for (int i = 0; i < inputVectorLength; i++)
                {
                    sortableVector[i] = myRandom.Next(100);                   
                }

            }
            
            Console.WriteLine("\nYour unsorted vector is: " + CreateVectorString(sortableVector));
            Console.WriteLine("Press any key to sort...");
            Console.ReadKey(true);

            bool smthChanged = false;

            do
            {
                smthChanged = false;

                for (int i = 0; i < inputVectorLength - 1; i++)
                {
                    if (sortableVector[i] > sortableVector[i + 1])
                    {
                        smthChanged = true;
                        int j = sortableVector[i];
                        sortableVector[i] = sortableVector[i + 1];
                        sortableVector[i + 1] = j;
                    }

                }

            }

            while (smthChanged);

            Console.WriteLine("\nSorting done!");

            Console.WriteLine("\nYour sorted vector is: " + CreateVectorString(sortableVector));

            Console.WriteLine("Press any key to exit...");

            Console.ReadKey(true);
            
        }

        static int GatherIntegerInput (int minLimit, int maxLimit)
        {
            do
            {
                int userValue = -1; 
                string userInput = Console.ReadLine();
                bool parseSuccess = Int32.TryParse(userInput, out userValue);

                if (parseSuccess)
                {
                    if (minLimit < userValue && userValue <= maxLimit)
                    {
                        return userValue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!\nNumber must be between " + (minLimit+1) + " and " + maxLimit + ".");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!\nPlease enter a number.");
                }

            } while (true);
        }

        static string CreateVectorString (int[] userArray)
        {
            string convertedArray = "";

            for (int i = 0; i < userArray.Length; i++)
            {
                convertedArray = convertedArray + userArray[i].ToString();

                if (i != userArray.Length - 1)
                {
                    convertedArray = convertedArray + ", ";
                }
            }

            return convertedArray;
        }
              
    }
}
