using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Accauntant
    {
        public static bool AskBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            else
                return false;
        }
    }
}
