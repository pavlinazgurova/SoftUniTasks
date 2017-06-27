using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Max_Sequence_of_Equal_Elements
{
    class MaxSequenceofEqualElements
    {
        static void Main(string[] args)
        {
            var integerers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            var startPos = integerers[0];
            var startLength = 1;
            var bestStart = integerers[0];
            var bestLenght = 1;

            for (int i = 1; i < integerers.Count; i++)
            {
                
                if (integerers[i] == integerers[i - 1])
                {
                    startLength++;
                    if (startLength > bestLenght)
                    {
                        bestStart = integerers[i];
                        bestLenght = startLength;
                    }
                }
                else
                {
                    startPos = integerers[i];
                    startLength = 1;
                }
            }

            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write($"{bestStart} ");
            }
        }
    }
}
