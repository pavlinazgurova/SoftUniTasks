using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            var times = multiplier;

            if (multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", num, multiplier, num * multiplier);
            }

            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, times, num * times);
                times++;
            }
        }
    }
}
