﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before: \na = {a}\nb = {b}");
            int temporary = a;
            a = b;
            b = temporary;

            Console.WriteLine($"After: \n a = {a} \n b = {b}");
        }
    }
}
