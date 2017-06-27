using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(decimal.Parse).
                ToList();
            integers.Sort();
            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] == integers[integers.Count - 1])
                {
                    Console.Write($"{integers[i]} ");
                }
                else
                {
                    Console.Write($"{integers[i]} <= ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
