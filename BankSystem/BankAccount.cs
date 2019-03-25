using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public delegate void SendMessageDelegate(string message);

    public class BankAccount
    {
        public event SendMessageDelegate ReportEvent;

        public string FullName { get; set; }
        public int Sum { get; private set; } = 0;  

        public void AddSum(int sum)
        {
            Sum += sum;
            ReportEvent?.Invoke($"Вам начисленно {sum}");/*Мы можем писать или не писать Invoke это синтаксический сахар*/
        }

        public int WithDrawSum(int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                ReportEvent?.Invoke($"У вас снято {sum}");
                return sum;
            }
            ReportEvent?.Invoke($"Недостаточно средств");
            return -1;
        }
    }
}
