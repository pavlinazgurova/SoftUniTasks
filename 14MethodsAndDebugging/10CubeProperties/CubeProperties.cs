using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double lenth = 0;

            if (parameter == "face")
            {
                lenth = side * Math.Sqrt(2);
            }
            else if (parameter == "space")
            {
                lenth = side * Math.Sqrt(3);
            }
            else if (parameter == "volume")
            {
                lenth = Math.Pow(side, 3);
            }
            else if (parameter == "area")
            {
                lenth = Math.Pow((6 * side), 2);
            }

            Console.WriteLine($"{lenth:f2}");
        }
    }
}
