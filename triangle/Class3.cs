using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Triangle
    {
        //public Point A;
        //public Point B;
        //public Point C;
        //public double AB;
        //public double CA;
        //public double BC;

            Point[] points = new Point[3];
            Edge[] edges = new Edge[3];
        
        public Triangle(Point ab, Point ac, Point bc)
        {
            points[0] = ab;
            points[1] = ac;
            points[2] = bc;
            Edges();
        }


        public void Edges()
        {
            for (int i = 0; i < 3; i++)
            {
                edges[i] = new Edge(points[i], points[(i + 1) % 3]);
            }
        }


        public bool IsFalse()
        {
            if (((edges[0].GetLength() == edges[1].GetLength()) && (edges[1].GetLength() != edges[2].GetLength())) ||
                ((edges[2].GetLength() == edges[1].GetLength()) && (edges[1].GetLength() != edges[0].GetLength())) ||
                ((edges[2].GetLength() == edges[0].GetLength()) && (edges[0].GetLength() != edges[1].GetLength())))
            {
                return true;
            }
            return false;
            {
                Console.WriteLine("Вы не можете использовать эти точки для создания треугольника");
            }
        }



        public bool IsRight()
        {
            if (Math.Pow(edges[0].GetLength(), 2) + Math.Pow(edges[1].GetLength(), 2) == Math.Pow(edges[2].GetLength(), 2) ||
                Math.Pow(edges[0].GetLength(), 2) + Math.Pow(edges[2].GetLength(), 2) == Math.Pow(edges[1].GetLength(), 2) ||
                Math.Pow(edges[1].GetLength(), 2) + Math.Pow(edges[2].GetLength(), 2) == Math.Pow(edges[0].GetLength(), 2))
            {
                return true;
            }
            return false;
        }


      
        public double Perimeter()
        {
            return edges[0].GetLength() + edges[1].GetLength() + edges[2].GetLength();
        }


        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - edges[0].GetLength()) * (p - edges[1].GetLength()) * (p - edges[2].GetLength()));
        }
        static public double AvgPerimeter(Triangle[] mas)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {

                if (mas[i].IsRight)
                {
                    sum += triangles[i].Perimeter;
                    count++;
                }
            }
            return sum / count;
        }


        static public double AvgArea(Triangle[] mas)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].IsFalse)
                {
                    sum += triangles[i].Area;
                    count++;
                }
            }
            return sum / count;
        }

        public Point[] GetPoints()
        {
            return points;
        }

        public Point[] GetPoints()
        {
            return points;
        }


        public Edge[] GetEdges()
        {
            return edges;
        }

       
}
}
