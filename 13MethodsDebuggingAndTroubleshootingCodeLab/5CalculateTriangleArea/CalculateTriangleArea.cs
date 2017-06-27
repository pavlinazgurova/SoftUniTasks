using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalcArea(width, height);
            Console.WriteLine(area);
        }

        static double CalcArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
