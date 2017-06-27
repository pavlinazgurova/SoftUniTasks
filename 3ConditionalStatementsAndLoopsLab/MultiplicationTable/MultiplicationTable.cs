using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var times = 1;
            
            for (int i = 1; i <= 10; i++)
            {                
                Console.WriteLine("{0} X {1} = {2}", num, times, num * times);
                times++;
            }
        }
    }
}
