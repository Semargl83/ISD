using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
  public class Content
    {
        public string BookContent { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Содержание книги: "+BookContent);
            
        }
    }
}
