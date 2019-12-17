using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GoodPupil:Pupil
    {
        public override void Study()
        { Console.WriteLine("Ученик очень старается"); }
        public override void Read()
        { Console.WriteLine("Грамотно и быстро читает"); }
        public override void Write()
        { Console.WriteLine("Пишет без ошибок и аккуратно"); }
        public override void Relax()
        { Console.WriteLine("Отдыхает мало, много занимается"); }
    }
}
