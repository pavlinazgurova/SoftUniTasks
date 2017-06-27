using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexandBinary
{
    class IntegerToHexandBinary
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var toHex = Convert.ToString(num, 16).ToUpper();
            var toBinary = Convert.ToString(num, 2).ToUpper();

            Console.WriteLine($"{toHex}\n{toBinary}");
        }
    }
}
