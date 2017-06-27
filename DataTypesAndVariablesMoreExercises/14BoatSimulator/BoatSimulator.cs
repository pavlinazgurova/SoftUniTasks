using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14BoatSimulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char charForFirst = char.Parse(Console.ReadLine());
            char charForSecond = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            var movesForFirst = 0;
            var movesForSecond = 0;

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine();

                if (input == "UPGRADE")
                {
                    charForFirst += (char)3;
                    charForSecond += (char)3;
                }

                else
                {
                    if (i % 2 == 1)
                    {
                        movesForFirst += input.Length;
                    }
                    else if (i % 2 == 0)
                    {
                        movesForSecond += input.Length;
                    }
                }

                if (movesForFirst >= 50 || movesForSecond >= 50)
                {
                    if (movesForFirst >= 50)
                    {
                        Console.WriteLine(charForFirst);
                    }
                    else
                    {
                        Console.WriteLine(charForSecond);
                    }
                    return;
                }
                               
            }
            if (movesForFirst > movesForSecond)
            {
                Console.WriteLine(charForFirst);
            }
            else
            {
                Console.WriteLine(charForSecond);
            }

        }
    }
}
