using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    class DNASequences
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var a = (char)65;
            var c = Convert.ToChar(67);
            var g = Convert.ToChar(71);
            var t = Convert.ToChar(84);

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        if (i + j + k >= n)
                        {
                            Console.Write("O" + 
                                ("" + i + j + k).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4','T') +
                                "O ");
                        }
                        else
                        {
                            Console.Write("X" +
                                ("" + i + j + k).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') +
                                "X ");
                        }
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
