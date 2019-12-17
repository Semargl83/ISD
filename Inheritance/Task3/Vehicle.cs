using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vehicle
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Speed { get; set; }
        public int ReleaseDate {get;set;}
        public Vehicle() { }
        public Vehicle(string name, decimal price, int speed, int reliseData)
        {
            Name = name;
            Price = price;
            Speed = speed;
            ReleaseDate = reliseData;
        }
    }
}
