using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
	class Triangle
	{
        public readonly Point Point1;
        public readonly Point Point2;
        public readonly Point Point3;

        private Edge edge1;
        private Edge edge2;
        private Edge edge3;

        public Triangle(Point point1, Point point2, Point point3)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Point3 = point3;
            this.edge1 = new Edge(Point1, Point2);
            this.edge2 = new Edge(Point2, Point3);
            this.edge3 = new Edge(Point3, Point1);

            if ((edge1.Length >= edge2.Length + edge3.Length) ||
                (edge2.Length >= edge1.Length + edge3.Length) ||
                (edge3.Length >= edge2.Length + edge1.Length))
            {
                throw new System.ArgumentException("Треугольника не существует");
            }
       }

        public double Perimeter
        {
            get
            {
                return edge1.Length + edge2.Length + edge3.Length;
            }
        }

        public double Area
        {
            get
            {
                double p = (edge1.Length + edge2.Length + edge3.Length) / 2;
                return Math.Sqrt(p * (p - edge1.Length) * (p - edge2.Length) * (p - edge3.Length));
            }
        }

        public bool Rectangled
        {
            get
            {
                return (Math.Sqrt(Math.Pow(edge1.Length, 2) + Math.Pow(edge2.Length, 2)) == edge3.Length ||
                    (Math.Sqrt(Math.Pow(edge2.Length, 2) + Math.Pow(edge3.Length, 2)) == edge1.Length ||
                    (Math.Sqrt(Math.Pow(edge3.Length, 2) + Math.Pow(edge1.Length, 2))) == edge2.Length));
            }
        }

        public bool Isosceles
        {
            get
            {
                return (edge1.Length == edge2.Length || edge1.Length == edge3.Length || edge2.Length == edge3.Length);

            }
        }

        public static bool operator ==(Triangle obj1, Triangle obj2)
        {
            return (obj1.edge1 == obj2.edge1 && obj2.edge2 == obj1.edge2 && obj1.edge3 == obj2.edge3);
        }

        public static bool operator !=(Triangle obj1, Triangle obj2)
        {
            return (obj1.edge1 != obj2.edge1 && obj2.edge2 != obj1.edge2 && obj1.edge3 != obj2.edge3);
        }
    }
}
