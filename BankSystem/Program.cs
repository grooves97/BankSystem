﻿using System;
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
            var account = new BankAccount
            {
                FullName="П.П.Петрович"
            };

            account.RegisterReporter(new SendMessageDelegate(new ConsoleReporter().SendMessage));

            account.AddSum(1000);
            account.WithDrawSum(100);
        }
    }
}
