using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook asus;
            asus.model = "Stels 007";
            asus.produktion = "Mi7";
            asus.price = 1220.50;

            Notebook hp = new Notebook("HP Notebook - 14-cm1011ur", "hewlett_packard", 1089.49);
                hp.ShowNotebook();
            asus.ShowNotebook();
            Console.ReadKey();
        }
    }
}
