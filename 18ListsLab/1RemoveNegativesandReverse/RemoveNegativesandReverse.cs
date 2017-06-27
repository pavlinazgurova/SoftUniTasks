using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RemoveNegativesandReverse
{
    class RemoveNegativesandReverse
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            integers.Reverse();

            

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] < 0)
                {
                    integers.Remove(integers[i]);
                    i -= 1;
                }
            }
            if (integers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", integers));
            }
            
        }
    }
}
