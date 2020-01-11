using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    enum Colors
    {
        White = 1,
        Yellow,
        Red,
        Cyan,
        Blue,
        Green,
        Magenta,
        Gray
    }
    class Program
    {
        
    static void Main(string[] args)
        {
            string stroka; int color;
            Console.Write("Введите текст: ");
            stroka = Console.ReadLine();
            Console.WriteLine("Выберите цвет: 1-Белый, 2-Желтый, 3-Красный, 4-Голубо-зеленый, 5-Синий, 6-Зеленый, 7-Пурпурный, 8-Серый");
            color = Convert.ToInt32(Console.ReadLine());
            if (color < 1 || color > 8) { Console.WriteLine("Нет такого цвета!!!"); }
            else
            {
                Console.Write("Ваш текс: ");
                ForPrint.Print(stroka, color);
            }
            Console.ReadKey();
        }
    }
}
