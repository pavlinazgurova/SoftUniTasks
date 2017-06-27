using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal volume = 0m;
            string biggestKeg = string.Empty;
            decimal biggest = 0; 

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = (decimal)Math.PI * (radius * radius) * height;

                if (volume > biggest)
                {
                    biggest = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
