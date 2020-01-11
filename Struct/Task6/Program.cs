using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    enum Post { Cap = 120, Cook = 110, Boatswain = 90, Locman = 80, Shkiper = 50, Wiper = 40 }
    class Program
    {
        
        static void Main(string[] args)
        {            
            Post wiper = Post.Wiper;
            Console.WriteLine(Accauntant.AskBonus(wiper, 10) ? "Работник достоин премии" : "Работник ленивый ленивец");
            Console.ReadKey();
        }
    }
}
