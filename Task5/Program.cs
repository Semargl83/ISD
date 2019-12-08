using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static string Input(string variableName)
        {
            Console.Write("Введите " + variableName + ": ");
            return Console.ReadLine();

        }
                   static void Main(string[] args)
            {
                string login = Input("login");
                string firstName = Input("Имя");
                string lastName = Input("Фамилию");
                int age = Convert.ToInt32(Input("Возраст"));
                Console.Clear();

                User user = new User(login, firstName, lastName, age);
                Console.WriteLine(user.ToString());
                Console.ReadKey();
            }
    }
 }
