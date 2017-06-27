using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(decimal.Parse).
                ToList();


            for (int i = 1; i < integers.Count; i++)
            {
                if (integers[i] == integers[i - 1])
                {
                    integers[i] = integers[i] + integers[i - 1];
                    integers.Remove(integers[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ",integers));
        }
    }
}
