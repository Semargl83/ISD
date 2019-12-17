using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Printer
    {
        public virtual void Print (string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Выводим: '{value}' стандартным цветом");
        }
    }
}
