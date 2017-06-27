using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= num; i++)
            { 
                    Console.WriteLine((2 * i - 1));
                    sum = sum + (2 * i - 1);                                               
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
