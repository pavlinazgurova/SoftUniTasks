using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6CatchtheThief
{
    class CatchtheThief
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var n = long.Parse(Console.ReadLine());
            
            long max = 0;

            switch (type)
            {
                case "sbyte":
                    max = sbyte.MaxValue;
                    break;
                case "int":
                    max = int.MaxValue;
                    break;
                case "long":
                    max = long.MaxValue;
                    break;
                default:
                    break;
            }
            var closest = long.MinValue;
            for (int i = 1; i <= n; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if (id <= max)
                {
                    if (id > closest)
                    {
                        closest = id;
                    }
                }
            }
            Console.WriteLine(closest);
        }
    }
}
