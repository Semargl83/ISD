using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(5, 6, "A");
            Point B = new Point(3, 1, "B");
            Point C = new Point(9, 3, "C");
            Point D = new Point(11, 8, "D");
            Point E = new Point(6, 12, "E");
            Figure figure_1 = new Figure(A, B, C);
            Figure figure_2 = new Figure(A, B, C, D);
            Figure figure_3 = new Figure(A, B, C, D, E);
            figure_1.PerimetrCalculator();
            figure_2.PerimetrCalculator();
            figure_3.PerimetrCalculator();
            Console.ReadKey();

        }
    }
}
