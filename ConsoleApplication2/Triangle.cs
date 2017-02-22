using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
	class Triangle
	{
        private int x;
        private int y;
        private int z;

        public Triangle (int x, int y, int z){
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public int Perimeter
        {
            get
            {
                return x + y + z;
            }
        }
	}
}
