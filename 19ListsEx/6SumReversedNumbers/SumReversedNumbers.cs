using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Select(a => int.Parse(new string (a.ToString().Reverse().ToArray())))
                .Sum());
        }
    }
}
