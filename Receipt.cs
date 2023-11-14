using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Receipt // квитанция
    {
        internal int number;
        internal DateTime issueDate;
        internal decimal amount;

        public Receipt(int number, DateTime issueDate, decimal amount)
        {
            this.number = number;
            this.issueDate = issueDate;
            this.amount = amount;
        }

        virtual public void PrintInfo()
        {
            Console.WriteLine("Номер квитанции: " + number);
            Console.WriteLine("Дата квитанции: " + issueDate);
            Console.WriteLine("Сумма в квитанции: " + amount);
        }
    }
}
