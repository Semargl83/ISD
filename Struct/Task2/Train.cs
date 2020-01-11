using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct Train
    {
        public string destinationPoint;
        public int numberTrain;
        public DateTime departureTime;
        public Train(string destPoint, int numTrain, DateTime time)
        {
            this.destinationPoint = destPoint;
            this.numberTrain = numTrain;
            this.departureTime = time;
        }

        public static void TrainSort(Train[] trains)   //сортировка
        {
            int temp;
            for (int i = 0; i < trains.Length-1; i++)
            {
                for (int j = i+1; j < trains.Length; j++)
                {
                    if (trains[i].numberTrain > trains[j].numberTrain)
                    {
                        temp= trains[i].numberTrain;
                        trains[i].numberTrain = trains[j].numberTrain;
                        trains[j].numberTrain = temp;
                    }
                }

            }
        }
        public void showTrain()
        {
            Console.WriteLine($"Поезд номер - {numberTrain} до станции {destinationPoint} отправляется в {departureTime}");
        }
    }
}
