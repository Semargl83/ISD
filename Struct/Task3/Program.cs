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
            MyStruct myStruct;
            myStruct.change = "не изменено";
            MyClass myClass = new MyClass();
            myClass.change= "не изменено";
            Console.WriteLine($"myStruct:{myStruct.change}, myClass:{myClass.change}");   //myStruct:не изменено, myClass:не изменено
            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine($"myStruct:{myStruct.change}, myClass:{myClass.change}");  //myStruct:не изменено, myClass:изменено
            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)      // в этом случае мы работаем со ссылочным типом который ссылается на один объект
        {
            myClass.change= "изменено";
        }
        static void StruktTaker(MyStruct myStruct)   //создается новый объект структурного типа со своим значением
        {
            myStruct.change = "изменено";
        }
    }
}
