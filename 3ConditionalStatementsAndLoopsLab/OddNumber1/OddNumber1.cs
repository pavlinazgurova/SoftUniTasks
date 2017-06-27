using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber1
{
    class OddNumber1
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    num = Math.Abs(int.Parse(Console.ReadLine()));
                }
                else if (num % 2 == 1)
                {
                    break;
                }
            }
            Console.WriteLine("The number is: " + num);
        }
    }
}
