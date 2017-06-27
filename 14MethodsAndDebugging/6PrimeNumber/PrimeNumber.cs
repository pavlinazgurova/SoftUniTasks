using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            if (CheckIsItPrime(num))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static bool CheckIsItPrime(long num)
        {
            if (num == 0) return false;
            if (num == 1) return false;
            if (num == 2) return true;

            long boundary = (long)Math.Floor(Math.Sqrt(num));

            for (int i = 2; i <= boundary; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
