using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Invoice : Receipt
    {
        internal string supplier;

        public Invoice(int receiptNumber, DateTime issueDate, decimal amount, string supplier) : base(receiptNumber, issueDate, amount)
        {
            this.supplier = supplier;
        }

        override public void PrintInfo()
        {
            Console.WriteLine("Номер накладной: " + number);
            Console.WriteLine("Дата накладной: " + issueDate);
            Console.WriteLine("Сумма в накладной: " + amount);
            Console.WriteLine("Поставщик в накладной: " + supplier);
        }
    }
}
