using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var factorial = GetFactorial(n);

            //Console.WriteLine(factorial);
            var zeros = CountZerosInFactOf(n);
            Console.WriteLine(zeros);
        }

        static BigInteger GetFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        static int CountZerosInFactOf(int n)
        {
            int result = 0;
            int start = 1;
            while (n >= start)
            {
                start *= 5;
                result += (int)n / start;
            }
            return result;
        }
    }
}
