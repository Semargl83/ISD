using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 12345;
            address.Country = "Ukraine";
            address.City = "Dnipro";
            address.Street = "Vyazova";
            address.House = "13-B";
            address.Apartment = 666;
            Console.WriteLine($"User address index - {address.Index}, country - {address.Country}," +
                $" city - {address.City}, street - {address.Street}, house - {address.House}, " +
                $"apartment - {address.Apartment}.");
            Console.ReadLine();
        }
    }
}
