﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9MakeaWord
{
    class MakeaWord
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                word += letter;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
