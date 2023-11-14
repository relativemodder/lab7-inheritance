using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Document : Receipt
    {
        internal string description;

        public Document(int number, DateTime issueDate, decimal amount, string description) : base(number, issueDate, amount)
        {
            this.description = description;
        }
        override public void PrintInfo()
        {
            Console.WriteLine("Номер документа: " + number);
            Console.WriteLine("Дата документа: " + issueDate);
            Console.WriteLine("Сумма в документе: " + amount);
            Console.WriteLine("Описание документа: " + description);
        }
    }
}
