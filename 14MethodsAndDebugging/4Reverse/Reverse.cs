using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Reverse
{
    class Reverse
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());

            GetReverseOrder(num);            
        }

        static void GetReverseOrder(decimal num)
        {
            var reverse = num.ToString().Reverse().ToArray();           

            Console.WriteLine(reverse);
        }
    }
}
