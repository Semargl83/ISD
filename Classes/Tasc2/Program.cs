using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Введите первую сторону прямоугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону прямоугольника: ");
            double b = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(a,b);
            Console.WriteLine($"Прямоугольник со сотронами ({a};{b}) имеет площадь = {rectangle.Area}\n" +
                $"и периметр = {rectangle.Perimeter}" );
            Console.ReadKey();
        }
    }
}
