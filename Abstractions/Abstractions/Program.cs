using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler;
            Console.WriteLine("Выберите формат документа 1 - txt, 2 - doc, 3 - xml");
            string format = Console.ReadLine();
            switch (format)
            {
                case "1": 
                    { handler = new TXTHandler(); }
                    break;
                case "2":
                    { handler = new DOCHandler(); }
                    break;
                case "3":
                    { handler = new XMLHandler(); }
                    break;
                default:
                    { Console.WriteLine("Не корректный ввод");
                        handler = new DOCHandler();
                    }
                    break;
            }
            Console.WriteLine("Что вы хотите сделать: открыть - 1, создать - 2, изменить - 3,  сохранить - 4?");
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    { handler.Open(); }
                    break;
                case "2":
                    { handler.Create(); }
                    break;
                case "3":
                    { handler.Change(); }
                    break;
                case "4":
                    { handler.Save(); }
                    break;
                default:
                    {
                        Console.WriteLine("Не корректный ввод");                        
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
