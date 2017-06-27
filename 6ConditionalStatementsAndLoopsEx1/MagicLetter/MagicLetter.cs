using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            var third = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char p = first; p <= second; p++)
                    {
                        if (i != third && j != third && p != third)
                        {
                            Console.Write($"{i}{j}{p} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
