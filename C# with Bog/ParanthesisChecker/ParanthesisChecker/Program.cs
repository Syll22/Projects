using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParanthesisChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the text you want to be checked for paranthesis:");

            string inputStringToCheck = Console.ReadLine();


            if(BraketsBog(inputStringToCheck))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NOT OK");
            }
            int counter1 = 0; // counter for ( )
            int counter2 = 0; // counter for [ ]
            int counter3 = 0; // counter for { }
            int counter4 = 0; // counter for < >

            foreach (char stringCharacter in inputStringToCheck)
            {
                if (stringCharacter == '(')
                {
                    counter1++;
                }
                else if (stringCharacter == ')')
                {
                    counter1--;
                }
                else if (stringCharacter == '[')
                {
                    counter2++;
                }
                else if (stringCharacter == ']')
                {
                    counter2--;
                }
                else if (stringCharacter == '{')
                {
                    counter3++;
                }
                else if (stringCharacter == '}')
                {
                    counter3--;
                }
                else if (stringCharacter == '<')
                {
                    counter4++;
                }
                else if (stringCharacter == '>')
                {
                    counter4--;
                }
            }

            Console.ReadKey(true);
        }
        
        static bool BraketsBog(string str)
        {
            Stack<char> bracketStack = new Stack<char>();
            
            foreach (char c in str)
            {
                if(IsOpening(c))
                {
                    bracketStack.Push(c);
                }
                else if(IsClosing(c))
                {
                    if (bracketStack.Count == 0)
                    {
                        return false;
                    }

                    char c1 = bracketStack.Pop();

                    if(!isPair(c1, c))
                    {
                        return false;
                    }
                }
            }

            return bracketStack.Count == 0;
        }

        static bool IsOpening(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        static bool IsClosing(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        static bool isPair(char c1, char c2)
        {
            if (c1 == '(' && c2 == ')')
                return true;
            if (c1 == '[' && c2 == ']')
                return true;
            if (c1 == '{' && c2 == '}')
                return true;
            return false;
        }
    }
}
