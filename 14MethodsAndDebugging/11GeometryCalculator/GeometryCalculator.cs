using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                var area = CalculateTriangleArea(side, height);
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                var area = CalculateSquareArea(side);
                Console.WriteLine($"{area:f2}");
            }

            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                var area = CalculateRectangleArea(width, height);
                Console.WriteLine($"{area:f2}");
            }

            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                var area = CalculateCircleArea(radius);
                Console.WriteLine($"{area:f2}");
            }
        }

        static double CalculateTriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        static double CalculateSquareArea(double side)
        {
            var area = side * side;
            return area;
        }

        static double CalculateRectangleArea(double width, double height)
        {
            var area = width * height;
            return area;
        }

        static double CalculateCircleArea(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }
    }
}
