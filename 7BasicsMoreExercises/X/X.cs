using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("x");
            Console.Write(new string(' ', n - 2));
            Console.WriteLine("x");

            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.Write(new string(' ', 1 + i));
                Console.Write("x");
                Console.Write(new string(' ', n - 4 - (2 * i)));
                Console.Write("x");
                Console.WriteLine(new string(' ', i + 1));
            }

            Console.Write(new string(' ', n / 2));
            Console.Write("x");
            Console.WriteLine(new string(' ', n / 2));

            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.Write(new string(' ', (n / 2) - 1 - i));
                Console.Write("x");
                Console.Write(new string(' ', 1 + 2 * i));
                Console.Write("x");
                Console.WriteLine(new string(' ', (n / 2) - 1 - i));
            }

            Console.Write("x");
            Console.Write(new string(' ', n - 2));
            Console.WriteLine("x");
        }
    }
}
