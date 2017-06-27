using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList(); 

            var newNumbers = numbers.OrderByDescending(x => x).Take(3);

            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
