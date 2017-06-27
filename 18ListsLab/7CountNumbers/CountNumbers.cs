using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            var newList = new List<int>();

            integers.Sort();

            var count = 1;

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] == integers[i + 1])
                {
                    count++;
                    newList
                }
                else if ((integers[i] != integers[i + 1]) || integers[i] == integers[integers.Count - 1])
                {
                    count = 0;
                }
                Console.WriteLine($"{integers[1]} -> {count}");
            }
        }
    }
}
// 2 2 2 4 4 8 8 10