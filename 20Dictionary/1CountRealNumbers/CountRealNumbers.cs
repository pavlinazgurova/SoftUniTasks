using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(double.Parse).ToList();

            var dict = new SortedDictionary<double, int>();

            foreach (var item in list)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            foreach (var num in dict)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
