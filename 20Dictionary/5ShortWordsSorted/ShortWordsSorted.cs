using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().
                ToLower().
                Split(new char[] { '|', ' ', '[', ']', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '.' }, 
                StringSplitOptions.RemoveEmptyEntries).
                ToList();

            var newText = text.Where(x => x.Length < 5).Distinct().OrderBy(x => x);

            Console.WriteLine(string.Join(", ", newText));
        }
    }
}
