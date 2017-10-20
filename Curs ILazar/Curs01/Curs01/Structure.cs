using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs01
{
    public class Structure : Enumeration
    {
        public struct BankAccount
        {
            public long accNumber;
            public decimal accInterest;
            public AccountType accType;
        }
    }
}
