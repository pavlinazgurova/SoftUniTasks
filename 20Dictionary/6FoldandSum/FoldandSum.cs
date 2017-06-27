using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6FoldandSum
{
    class FoldandSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();

            var k = numbers.Count / 4;

            //int[] row1 = numbers.Take(k).Reverse().ToArray();
            //int[] row2 = numbers.Reverse().Take(k).ToArray();

            var row1 = numbers.Take(k).Reverse().ToList();
            var row2 = numbers.Skip(3 * k).Take(k).Reverse().ToList();

            var first = numbers.Skip(k).Take(k * 2).ToList();
            var second = row1.Concat(row2).ToList();

            var sum = new List<int>();

            for (int i = 0; i < k * 2; i++)
            {
                sum.Add(first[i] + second[i]);
            }

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
