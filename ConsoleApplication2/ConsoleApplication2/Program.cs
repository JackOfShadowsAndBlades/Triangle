using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void CalculateAvgPerimeter(Triangle[] Array)
        {
            int k = 0;
            double p = 0;
            for (int i = 0; i < Array.Length; i++)
                if (Array[i].Rectangled)
                {
                    k++;
                    p = p + Array[i].Perimeter;
                }
            if (k > 0)
            {
                Console.WriteLine(p / k);
            }
            else
            {
                Console.WriteLine("Нет прямоугольных треугольников");
            }

        }

        static void CalculateAvgArea(Triangle[] Array)
        {
            int k = 0;
            double s = 0;
            for (int i = 0; i < Array.Length; i++)
                if (Array[i].Isosceles)
                {
                    k++;
                    s = s + Array[i].Area;
                }
            if (k > 0)
            {
                Console.WriteLine(s / k);
            }
            else
            {
                Console.WriteLine("Нет равнобедренных треугольников");
            }
        }
        static void Main(string[] args)
        {
            var tri = new Triangle(new Point(1, 30), new Point(2, 1), new Point(1, 3));
            Triangle[] ArrayOfTriangles = new Triangle[1];
            ArrayOfTriangles[0] = new Triangle(new Point(1, 3), new Point(5, 4), new Point(3, 1));

            CalculateAvgArea(ArrayOfTriangles);
            CalculateAvgPerimeter(ArrayOfTriangles);

        }

       
    }
}
