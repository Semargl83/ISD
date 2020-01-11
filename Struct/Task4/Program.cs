using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayCalculator();
            Console.ReadLine();
        }
        static void BirthdayCalculator()
        {
            Console.WriteLine("Введите дату вашего рождения в формате ГГГГ.ММ.ДД:");           
            string[] birthday = Console.ReadLine().Split('.');
            try
            {
                DateTime inputDate = new DateTime(Convert.ToInt32(birthday[0]), Convert.ToInt32(birthday[1]), Convert.ToInt32(birthday[2]));
                DateTime nowTime = DateTime.Today;
                int ostDay = inputDate.DayOfYear -  DateTime.Now.DayOfYear;
                int age = DateTime.Now.Year - inputDate.Year;
                if (inputDate.Year > DateTime.Now.Year)
                    throw new Exception();
                else if (ostDay < 0)
                {
                    ostDay = nowTime.DayOfYear - DateTime.Now.DayOfYear + inputDate.DayOfYear;
                    age++;
                }
                Console.WriteLine($"До вашего следующего дня рождения осталось {ostDay} дней!\nВам исполняется {age} лет, У Вас все впереди!");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте ещё!");
                BirthdayCalculator();
            }
        }
    }
}
