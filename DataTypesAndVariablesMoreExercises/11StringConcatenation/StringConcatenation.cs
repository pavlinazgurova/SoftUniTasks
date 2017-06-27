using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string concatenation = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine();
                if (evenOrOdd == "odd")
                {
                    if (i % 2 == 1)
                    {
                        concatenation += input + delimiter;
                    }
                }
                else if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        concatenation += input + delimiter;
                    }
                }
            }
            concatenation = concatenation.Remove(concatenation.Length - 1);
            Console.WriteLine($"{concatenation}");
        }
    }
}
