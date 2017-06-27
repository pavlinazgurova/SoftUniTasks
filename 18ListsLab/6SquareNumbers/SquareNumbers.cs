using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            var newList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (Math.Sqrt(list[i]) == (int)Math.Sqrt(list[i]))
                {
                    newList.Add(list[i]);
                }
            }

            newList = newList.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
