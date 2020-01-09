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
            Train[] trains = new Train[8];
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

            //trains[trains.Length].TrainSort(trains);    не захотело работать

            int temp;
            for (int i = 0; i < trains.Length - 1; i++)
            {
                for (int j = i + 1; j < trains.Length; j++)
                {
                    if (trains[i].numberTrain > trains[j].numberTrain)
                    {
                        temp = trains[i].numberTrain;
                        trains[i].numberTrain = trains[j].numberTrain;
                        trains[j].numberTrain = temp;
                    }
                }

            }
            Console.Write("Введите номер интересующего Вас поезда: ");
            int input = Int32.Parse(Console.ReadLine());

            foreach (Train item in trains)
            {
                if (input == item.numberTrain)
                {
                    item.showTrain();
                }
                else
                {
                    Console.WriteLine("Запрашиваемого поезда нет в базе");
                }
            }

            Console.ReadLine();

        }
    }
}
