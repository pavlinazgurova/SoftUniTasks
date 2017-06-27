using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            var priceOne = long.Parse(Console.ReadLine());
            var priceTwo = long.Parse(Console.ReadLine());
            long totalPrice = 1;
            if (priceOne >= sbyte.MinValue && priceOne <= sbyte.MaxValue)
            {
                totalPrice = (4 * priceOne) + (10 * priceTwo);               
            }
            else
            {
                totalPrice = (4 * priceTwo) + (10 * priceOne);
            }

            Console.WriteLine(totalPrice);
        }
    }
}
