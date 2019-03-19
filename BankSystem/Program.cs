using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(new ConsoleReporter())
            {
                FullName="П.П.Петрович"
            };
            account.AddSum(1000);
            account.WithDrawSum(100);
        }
    }
}
