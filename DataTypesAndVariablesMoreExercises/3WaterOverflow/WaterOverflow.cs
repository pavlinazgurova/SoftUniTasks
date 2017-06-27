using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var totalQuantity = 0;

            for (int i = 1; i <= n; i++)
            {
                var quantity = int.Parse(Console.ReadLine());
                

                if ((totalQuantity + quantity) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else 
                {
                    totalQuantity += quantity;
                }                
            }
            Console.WriteLine(totalQuantity);
        }
    }
}
