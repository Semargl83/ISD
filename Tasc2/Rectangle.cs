using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle()
        {
            side1 = 0;
            side2 = 0;
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }
        double PerimeterCalculator(double side1, double side2)
        {
            return (side1 + side2)*2;
        }
        public double Area
        {
            get { return AreaCalculator(this.side1, this.side2); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(this.side1, this.side2); }
        }
    }
}
