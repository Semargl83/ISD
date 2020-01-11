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
            Train[] trains = new Train[4];
            for (int i = 0; i < trains.Length; i++)
            {
                try
                { Console.Write("Введите номер поезда: ");
                    trains[i].numberTrain = Int32.Parse(Console.ReadLine());
                    Console.Write("Введите пунк назначения: ");
                    trains[i].destinationPoint = Console.ReadLine();
                    Console.Write("Введите время прибытия в формате ЧЧ:ММ:СС: ");
                    trains[i].departureTime = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не верный формат ввода");break;
                }
            }
            Console.WriteLine();
            Train.TrainSort(trains);                       // вызов сортировки
            foreach (Train item in trains)
            {
                item.showTrain();
            }              //показать сортировку
             
            Console.Write("\nВведите номер интересующего Вас поезда: ");
            int input = Int32.Parse(Console.ReadLine());
            bool flag = true;

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].numberTrain == input)
                {
                    trains[i].showTrain();
                    flag = false;
                }                
            }
           if(flag)
            {
                Console.WriteLine("Запрашиваемого поезда нет в базе");
            }

            Console.ReadLine();
        }
    }
}
