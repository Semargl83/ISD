using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Car : Vehicle
    {
        public Car (){}

        public Car(string name, decimal price, int speed, int reliseData):base(name, price,speed,reliseData)
        {          
        }
        public void ShowCar()
        {
            Console.WriteLine($"Автомобиль {Name} выпущен в:- {ReleaseDate} году;" +
                $" \nКрейсерская скорость:- {Speed} км/ч; " +
                $"\nСтоимость авто:- {Price} грн; ");
            Console.WriteLine();
        }
    }
}
