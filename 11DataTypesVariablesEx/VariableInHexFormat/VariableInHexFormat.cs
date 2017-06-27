using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            var hex = Console.ReadLine();
            var myInt = Convert.ToInt32(hex, 16);
            Console.WriteLine(myInt);
        }
    }
}
