using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Edge
    {
        public readonly Point Point1;
        public readonly Point Point2;

        public double Length
        {
            get
            {
                return Math.Sqrt(
                      (Point1.X - Point2.X) * (Point1.X - Point2.X) +
                      (Point1.Y - Point2.Y) * (Point1.Y - Point2.Y)
                      );
            }
        }

        public Edge(Point point1, Point point2)
        {
            this.Point1 = point1;
            this.Point2= point2;
        }

        public static bool operator ==(Edge obj1, Edge obj2)
        {
            return (obj1.Point1 == obj2.Point1 && obj1.Point2 == obj2.Point2);
        }

        public static bool operator !=(Edge obj1, Edge obj2)
        {
            return (obj1.Point1 != obj2.Point1 && obj1.Point2 != obj2.Point2);
        }
    }
}
