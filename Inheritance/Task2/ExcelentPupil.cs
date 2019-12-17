using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ExcelentPupil:Pupil
    {
        public override void Study()
        { Console.WriteLine("Ученик вундеркинд"); }
        public override void Read()
        { Console.WriteLine("Читает лучше учителя"); }
        public override void Write()
        { Console.WriteLine("Пишет как рисует"); }
        public override void Relax()
        { Console.WriteLine("Про отдых забыл"); }
    }
}
