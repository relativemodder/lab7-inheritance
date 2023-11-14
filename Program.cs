using System;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример 1 Receipt:");
            Receipt exampleReceipt = new Receipt(1, DateTime.Now, 300);
            exampleReceipt.PrintInfo();

            Console.WriteLine("\n------------------------------------------------------------------------\n");

            Console.WriteLine("Пример 2 Invoice:");
            Receipt exampleInvoice = new Invoice(1, DateTime.Now, 200, "Кезин Андрей Денисович"); // Наследуемый класс МОЖНО кастить до базового
            exampleInvoice.PrintInfo();

            Console.WriteLine("\n------------------------------------------------------------------------\n");

            Console.WriteLine("Пример 3 Document:");
            Document exampleDocument = new Document(1, DateTime.Now, 150, " Тут не стал выпендриваться кастингом :)");
            exampleDocument.PrintInfo();

            Console.WriteLine("\n------------------------------------------------------------------------\n");

            Console.WriteLine("Пример 4 Bill:");
            Bill exampleBill = new Bill(1, DateTime.Now, 4000, "Вася Пупкин");
            exampleBill.PrintInfo();

            Console.WriteLine("\n------------------------------------------------------------------------\n");

            Console.ReadLine();
        }
    }
}