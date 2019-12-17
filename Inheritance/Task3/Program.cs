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
            Car ZaZ = new Car("Запорожец",50000, 80, 1958);
            Ship Kolibri = new Ship("Надувная лодка",4, "гаражи по месту", 2500, 10, 2016);
            Plane Ikar = new Plane("Мечта Икара", 1, 250, 3500, 50, 201);
            ZaZ.ShowCar();
            Kolibri.ShowPlane();
            Ikar.ShowPlane();
            Console.ReadKey();

        }
    }
}
