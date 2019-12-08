﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Point
    {
        private int x, y;
        private string name;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }
        public Point()
        {
            x = 0;
            y = 0;
            name = "point";
        }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
