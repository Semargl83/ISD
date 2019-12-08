using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private DateTime registerDate;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.firstName = name;
            this.lastName = surname;
            this.age = age;
            registerDate = DateTime.Now;
        }
        public override string ToString()
        {
            return "Login: " + login + " \nИмя: " + firstName + "\nФамилия: " + lastName + "\nВозраст: " + age + " \nДата регистрации: " + registerDate.ToString();
        }
    }
}
