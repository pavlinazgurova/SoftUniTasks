﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var calories = 0;
            string ingredients;
            for (int i = 1; i <= n; i++)
            {
                ingredients = Console.ReadLine().ToLower();

                if (ingredients == "cheese")
                {
                    calories += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredients == "salami")
                {
                    calories += 600;
                }
                else if (ingredients == "pepper")
                {
                    calories += 50;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
