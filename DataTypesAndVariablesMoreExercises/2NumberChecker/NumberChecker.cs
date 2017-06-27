using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
           
            try
            {
                long number = long.Parse(Console.ReadLine());

                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
