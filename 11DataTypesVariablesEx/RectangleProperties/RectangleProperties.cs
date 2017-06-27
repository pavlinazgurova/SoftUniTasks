using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var perimeter = 2.0 * (width + height);
            var area = width * height;
            var diagonal = Math.Sqrt(width * width + (height * height));

            Console.WriteLine($"{perimeter} \n{area} \n{diagonal}");
        }
    }
}
