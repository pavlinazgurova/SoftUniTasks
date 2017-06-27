using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            int max;
            int min;
            if (num1 > num2)
            {
                max = num1;
                min = num2;
            }
            else
            {
                max = num2;
                min = num1;
            }

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
