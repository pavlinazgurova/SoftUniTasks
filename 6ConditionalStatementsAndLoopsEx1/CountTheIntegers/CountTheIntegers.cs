using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int times = 0;
            
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    times++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(times);
            }
            
            
        }
    }
}
