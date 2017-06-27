using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SumMinMaxAverage
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");

        }
    }
}
