using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var firstPoint = GetClosest(x1, y1);
            var secondPoint = GetClosestPoint(x2, y2);

            if (firstPoint < secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double GetClosest(double x1, double y1)
        {
            var d1 = (x1 * x1) + (y1 * y1);
            return d1;
        }

        static double GetClosestPoint(double x2, double y2)
        {
            var d2 = (x2 * x2) + (y2 * y2);
            return d2;
        }
    }
}
