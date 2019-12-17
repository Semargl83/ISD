using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Ship : Vehicle
    {
        public int Passengers { get; set; }

        public string Port { get; set; }
        public Ship() { }
        public Ship(string name, int passengers, string port, decimal price, int speed, int reliseData) : base(name, price, speed, reliseData)
        {
            Passengers = passengers;
            Port = port;
        }
        public void ShowPlane()
        {
            Console.WriteLine($"Карабль {Name} выпущен:- {ReleaseDate} году;" +
                $" \nКрейсерская скорость:- {Speed}км/ч; " +
                $"\nСтоимость аппарата:- {Price} грн; " +
                $"\nПассажировместимость:- {Passengers} человек; " +
                $"\nПорт дислокации:- {Port}");
            Console.WriteLine();
        }
    }
}
