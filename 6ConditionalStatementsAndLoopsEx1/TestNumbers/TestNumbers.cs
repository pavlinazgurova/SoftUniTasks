using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            var count = 0;
            var sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {                    
                    if (sum >= max)
                    {
                        
                        break;
                    }
                    else
                    {
                        sum += (i * j) * 3;
                        count++;
                    }
                                      
                }               
            }
            if (sum >= max)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
            

        }
    }
}
