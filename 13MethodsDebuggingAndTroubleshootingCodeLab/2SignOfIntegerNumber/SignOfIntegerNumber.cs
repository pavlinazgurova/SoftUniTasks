using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void PrintSign(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
