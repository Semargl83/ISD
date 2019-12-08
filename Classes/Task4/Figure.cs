using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Figure
    {
        Point A, B, C, D, E;
        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Figure(Point A, Point B, Point C, Point D) :this(A,B,C)
        {
            this.D = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E):this(A,B,C,D)
        {
            this.E = E;
        }
        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }
        public void PerimetrCalculator()
        {
            if (D == null && E == null)
            { Console.WriteLine("Периметр треугольника = {0:0.000}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A))); }
            else if (E == null)
            { Console.WriteLine("Периметр прямоугольеика = {0:0.000}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A))); }
            else
            {
                Console.WriteLine("Периметр пятиугольника = {0:0.000}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A)));
            }

        }
    }
}
