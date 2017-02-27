using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Edge
    {
        Point a;
        Point b;
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow((a.GetX() - b.GetX()), 2) +
                             Math.Pow((a.GetY() - b.GetY()), 2));
        }
        public Edge(Point a, Point b)
        {
            a = a;
            b = b;
        }
        public Point Geta()
        {
            return a;
        }
        public Point Getb()
        {
            return b;
        }


    }
}
