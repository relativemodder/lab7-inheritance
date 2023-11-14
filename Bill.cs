using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Bill : Receipt
    {
        internal string recipient;

        public Bill(int number, DateTime issueDate, decimal amount, string recipient) : base(number, issueDate, amount)
        {
            this.recipient = recipient;
        }

        override public void PrintInfo()
        {
            Console.WriteLine("Номер счёта: " + number);
            Console.WriteLine("Дата выставления счёта: " + issueDate);
            Console.WriteLine("Сумма в счёте: " + amount);
            Console.WriteLine("Получатель счёта: " + recipient);
        }
    }
}
