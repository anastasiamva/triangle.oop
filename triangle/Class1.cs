using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Point
    {
        public int x;
        public int y;
         
        public Point(int x, int y)
            {
            x=x;
            y=y;
            }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
    }
}
