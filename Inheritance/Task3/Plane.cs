using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Plane:Vehicle
    {
        public int Passengers { get; set; }
        public int Fly { get; set; }

        public Plane() { }
        public Plane(string name, int passengers, int fly, decimal price, int speed, int reliseData) : base(name,price, speed, reliseData)
        {
            Passengers = passengers;
            Fly = fly;
        }
        public void ShowPlane()
        {
            Console.WriteLine($"Самолет {Name} выпущен:- {ReleaseDate} году;" +
                $" \nКрейсерская скорость:- {Speed} км/ч; " +
                $"\nСтоимость аппарата:- {Price} грн; " +
                $"\nПассажировместимость:- {Passengers} человек; " +
                $"\nЛетает на высоте:- {Fly} метров");
            Console.WriteLine();
        }
    }
}
