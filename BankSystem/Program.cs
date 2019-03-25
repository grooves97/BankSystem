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
            var account = new BankAccount
            {
                FullName="П.П.Петрович"
            };

            // var reporter = new ConsoleReporte();

            account.ReportEvent += new SendMessageDelegate(new ConsoleReporter().SendMessage);
            account.ReportEvent += new ConsoleReporter().SendMessage;
            account.ReportEvent += BlahBlah;

            account.ReportEvent += delegate (string text) {
                Console.WriteLine("asdasd");

                return;//можно не писать в случае с void
            };

            //лямбда
            account.ReportEvent += (mess) => Console.Write(mess);

            account.ReportEvent += (text) =>
            {
                Console.Write(text);
            };

            var data = new List<string>
            {
                "Алматы",
                "Караганда",
                "Нур-Султан"
            };

            //без лямбда и синтаксического сахара
            var buferList = new List<string>();
            foreach (var cityName in data)
            {
                if (cityName.ToLower().Contains("т"))
                {
                    buferList.Add(cityName);
                }
            }


            //с лямда и синтаксический сахар
            var result = data.Where(cityName => cityName.ToLower().Contains("т"));

            account.AddSum(1000);
            account.WithDrawSum(100);
        }

        private static void BlahBlah(string message)
        {

        }
    }
}
