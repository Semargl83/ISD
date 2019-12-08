using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Converter
    {

        public decimal USD { get; set; }
        public decimal EUR { get; set; }
        public decimal RUB { get; set; }
        public decimal UAH { get; set; }

        public Converter() { }
        public Converter(decimal usd, decimal eur, decimal rub)
        {
            this.USD = usd;
            this.EUR = eur;
            this.RUB = rub;
        }
      
        public static Converter CreateFromConsole()
        {
            Console.Write("Введите курсы гривны через пробел (USD EUR RUB): ");
            string[] kurs = Console.ReadLine().Split();
            return new Converter(decimal.Parse(kurs[0]), decimal.Parse(kurs[1]), decimal.Parse(kurs[2]));
        }
        public  decimal? ConvertConsole()
        {
            Console.Write("Введiть суму(грн):");
            decimal value = decimal.Parse(Console.ReadLine());
            Console.Write("Введiть номер валюты (1 - USD, 2 - EUR, 3 - RUB)");
            int currency = Int32.Parse(Console.ReadLine());
            switch (currency)
            {
                case 1: return MethodUsd(value);
                case 2: return MethodEur(value);
                case 3: return MethodRub(value);
            }
            return null;
        }
        public decimal MethodUsd(decimal value)
        {               
                return value/USD;
        }
        public decimal MethodEur(decimal value)
        {
            return value / EUR;
        }
        public decimal MethodRub(decimal value)
        {
            return value / RUB;
        }




    }
}
