using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (char symbol = (char)begin; symbol <= (char)end; symbol++)
            {
                Console.Write((char)symbol + " ");                
            }
        }
    }
}
