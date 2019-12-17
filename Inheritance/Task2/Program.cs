using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Pupil firstPupil = new ExcelentPupil();
            Pupil secondPupil = new GoodPupil();
            Pupil thirdPupil = new GoodPupil();
            Pupil fourthPupil = new BadPupil();

            ClassRoom classRoom = new ClassRoom(firstPupil, secondPupil, thirdPupil, fourthPupil);

            foreach (Pupil p in classRoom.Pupils)
            {
                Console.WriteLine($"{i}-й Ученик") ;
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine();
                i++;
            }            
            Console.ReadLine();
        }
    }
}
