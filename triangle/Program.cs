using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Point ab = new Point(0, 0),
                  ac = new Point(2, 1),
                  bc = new Point(3, 4);

            Triangle N = new Triangle(ab, ac, bc);


            Triangle[] triangles = GetRandomTriangles(10);

            double avgperimeter = 0, avgarea = 0;
            int right = 0, sosceles = 0;

            for (int i = 0; i < triangles.Length; i++)
            {
                if (triangles[i].IsRight())
                {
                    right++;
                    avgperimeter += triangles[i].Perimeter();
                }
                else if (triangles[i].IsFalse())
                {
                    sosceles++;
                    avgarea += triangles[i].Area();
                }
            }

            Console.WriteLine(avgperimeter / right);
            Console.WriteLine(avgarea / sosceles);

            Console.ReadLine();
        }
        static Triangle[] GetRandomTriangles(int countOfTriangles)
        {
            Random gen = new Random();
            Triangle[] triangles = new Triangle[countOfTriangles];
            for (int i = 0; i < countOfTriangles; i++)
            {
                triangles[i] = new Triangle(new Point(gen.Next(10), gen.Next(10)),
                                            new Point(gen.Next(10), gen.Next(10)),
                                            new Point(gen.Next(10), gen.Next(10)));
            }
            return triangles;
        }
    }
}

