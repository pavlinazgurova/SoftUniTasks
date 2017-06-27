using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            long n = 1;
            
            if (long.TryParse(symbol, out n))
            {
                Console.WriteLine("digit");
                return;
            }
            if (symbol == "a" || symbol == "o" || symbol == "e" || symbol == "y" || symbol == "u" || symbol == "i")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
