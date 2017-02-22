using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Point
    {
        public readonly double X;
        public readonly double Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static bool operator ==(Point obj1, Point obj2)
        {
            return (obj1.X == obj2.X && obj1.Y == obj2.Y);
        }

        public static bool operator !=(Point obj1, Point obj2)
        {
            return (obj1.X != obj2.X && obj1.Y != obj2.Y);
        }
    }
}
