using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BadPupil : Pupil
    {
        public override void Study()
        { Console.WriteLine("Ученик забыл что такое учиться"); }
        public override void Read()
        { Console.WriteLine("Плохо читает"); }
        public override void Write()
        { Console.WriteLine("Пишет как курица лапой"); }
        public override void Relax()
        { Console.WriteLine("Отдыхает как царь"); }

    }
}
