using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.cs
{
  class Program : Structure
    {

       public static void Main(string[] args)
        {
           
            AccountType account1;
            AccountType account2;
            BankAccount account;

            //account.accNumber = 123;
            //account.accInterest = 3200;
            account.accType = AccountType.Cec;
           // account.accType = AccountType.Depozit;

            account1 = AccountType.Cec;
            account2 = AccountType.Depozit;
            //account1= AccountType.Depozit;

            Console.WriteLine("{0}, {1}" , account1, account2);
           
            Console.WriteLine("Dati numarul de cont: ");
            account.accNumber = long.Parse(Console.ReadLine());
           
            Console.WriteLine("Dati o suma: ");
            account.accInterest = long.Parse(Console.ReadLine());

            Console.WriteLine("Suma se va depune in Cec pentru a se depune in depozit tipariti D:");           

            if (char.Parse(Console.ReadLine()) == 'D')
            {
                account.accType = AccountType.Depozit;
            }

            Console.WriteLine("{0}, {1}, {2}", account.accNumber, account.accInterest, account.accType);

        }
    }
}
