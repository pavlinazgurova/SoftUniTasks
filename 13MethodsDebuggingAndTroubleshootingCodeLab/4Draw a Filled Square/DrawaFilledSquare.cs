using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Draw_a_Filled_Square
{
    class DrawaFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFirstAndLastLine(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddlePart(n);
            }
            PrintFirstAndLastLine(n);

        }

        static void PrintFirstAndLastLine(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintMiddlePart(int n)
        {
            Console.Write("-");
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
