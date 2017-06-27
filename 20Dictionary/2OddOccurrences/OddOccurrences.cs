using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().ToLower().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToList();

            var dict = new Dictionary<string, int>();

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

            var newList = new List<string>();

            foreach (var i in dict)
            {
                if (i.Value % 2 == 1)
                {
                    newList.Add(i.Key);
                }               
            }

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
