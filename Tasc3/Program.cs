using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.Write("Введите автора: ");
            string authorName = Console.ReadLine();
            Console.Write("Введите название книги: ");
            string bookName = Console.ReadLine();
            Console.Write("Введите содержание книги: ");
            string content = Console.ReadLine();
            Book book = new Book(authorName, bookName, content);
            book.Show();
            Console.ReadKey();
        }
    }
}
