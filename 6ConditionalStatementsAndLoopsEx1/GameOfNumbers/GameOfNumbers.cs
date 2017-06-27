using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicalNum = int.Parse(Console.ReadLine());

            var count = 0;
            var sum = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    sum = i + j;
                    count++;
                    if (sum == magicalNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNum}");
                        return;
                    }

                                      
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicalNum}");
        }
    }
}
