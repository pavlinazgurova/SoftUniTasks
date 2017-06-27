using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double z1 = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());


            var d1 = (x1 * x1) + (y1 * y1);
            var d2 = (x2 * x2) + (y2 * y2);

            var resultFirst = d1 + d2;

            var d3 = (z1 * z1) + (p1 * p1);
            var d4 = (z2 * z2) + (p2 * p2);

            var resultSecond = d3 + d4;

            if (resultFirst > resultSecond)
            {
                if (d1 < d2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }

            }
            else
            {
                if (d3 < d4)
                {
                    Console.WriteLine($"({z1}, {p1})({z2}, {p2})");
                }
                else
                {
                    Console.WriteLine($"({z2}, {p2})({z1}, {p1})");
                }
            }

            //var first = GetFirstClosest(x1, y1, x2, y2);
            //var second = GetSecondClosest(z1, p1, z2, p2);

            //if (first > second)
            //{
            //    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            //}
            //else
            //{
            //    Console.WriteLine($"({z2}, {p2})({z1}, {p1})");
            //}
            //GetFirstClosest(x1, y1, x2, y2);
            //GetSecondClosest(z1, p1, z2, p2);
        }

        static double GetFirstClosest(double x1, double y1, double x2, double y2)
        {
            var d1 = (x1 * x1) + (y1 * y1);
            var d2 = (x2 * x2) + (y2 * y2);

            var result = d1 + d2;

            return result;

            //if (d1 < d2)
            //{
            //    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            //}
            //else
            //{
            //    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            //}
        }

        static double GetSecondClosest(double z1, double p1, double z2, double p2)
        {
            var d3 = (z1 * z1) + (p1 * p1);
            var d4 = (z2 * z2) + (p2 * p2);



            var result2 = d3 + d4;

            return result2;

            //if (d3 < d4)
            //{
            //    Console.WriteLine($"({z1}, {p1})({z2}, {p2})");
            //}
            //else
            //{
            //    Console.WriteLine($"({z2}, {p2})({z1}, {p1})");
            //}
        }

        static void PrintTheClosest(double d1, double d2, double d3, double d4)
        {

        }
    }
}
