﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            try
            {
                long num = long.Parse(Console.ReadLine());

                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (num >= int.MinValue && num <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (num >= long.MinValue && num <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Rainy");
            }
            
        }
    }
}
