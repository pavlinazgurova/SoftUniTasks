using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var product = (double)width * (double)height;
            double megapixels =product / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(megapixels, 1)}MP");
        }
    }
}
