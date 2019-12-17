using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Новый цвет";
            Printer print = new GreenPrinter();
            print.Print(value);
            print = new Printer();
            print.Print(value);
            print = new YellowPrinter();
            print.Print(value);
            print = new Printer();
            print.Print(value);
            print = new RedPrinter();
            print.Print(value);
            print = new Printer();
            print.Print(value);
            Console.ReadKey();
        }
    }
}
