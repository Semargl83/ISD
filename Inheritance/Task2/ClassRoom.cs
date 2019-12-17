using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
      public readonly List<Pupil> Pupils = new List<Pupil>();

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(pupil3);
            Pupils.Add(pupil4);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(pupil3); ;
            Pupils.Add(new BadPupil());
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(new GoodPupil());
            Pupils.Add(new BadPupil());
        }                
    }
}
