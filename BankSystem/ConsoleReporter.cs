using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class ConsoleReporter : IReporter
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
