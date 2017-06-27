using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            var diff = Math.Abs(num1 - num2);

            if (diff < 0.000001)
            {
                Console.WriteLine("True");
            }
            else if (diff >= 0.000001)
            {
                Console.WriteLine("False");
            }
        }
    }
}
