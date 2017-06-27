using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int currentNum = 1; currentNum <= num; currentNum++)
            {
                int sumOfDigits = 0;
                int digits = currentNum;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{currentNum} -> {special}");
            }
        }
    }
}
