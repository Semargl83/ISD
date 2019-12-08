using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {          
            Converter converter = new Converter(23,27,3);
            Console.ReadLine();
            Console.WriteLine($"Получите на руки {converter.ConvertConsole()} "); 
            Console.ReadLine();
        }
    }
}
