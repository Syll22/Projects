using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs01
{
    class Program : Structure
    {
        static void Main(string[] args)
        {
            AccountType account1 = AccountType.Cec;
            AccountType account2 = AccountType.Deposit;

            Console.WriteLine("Account 1: {0}\nAccount 2: {1}",account1, account2);

            BankAccount account;
            account.accNumber = 123;
            account.accInterest = 3200.00M;
            account.accType = AccountType.Cec;

            Console.WriteLine("Account Number: {0}\nInterest: {1}\nType: {2}",account.accNumber, account.accInterest, account.accType);

            Console.ReadKey();
        }
    }
}
