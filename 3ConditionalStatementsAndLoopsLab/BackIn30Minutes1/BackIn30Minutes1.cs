using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes1
{
    class BackIn30Minutes1
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            if (minutes < 30)
            {
                minutes = minutes + 30;
                Console.WriteLine($"{hours}:{minutes}");
                return;
            }

            if (minutes >= 30 && hours < 23)
            {
                minutes = minutes - 30;
                if (minutes <= 9)
                {
                    hours++;
                    Console.WriteLine($"{hours}:0{minutes}");
                }
                else if (minutes >= 10)
                {
                    hours++;
                    Console.WriteLine($"{hours}:{minutes}");
                }
            }

            if (hours == 23 && minutes >= 30)
            {
                hours = 0;
                minutes = minutes - 30;
                if (minutes <= 9)
                {
                    Console.WriteLine($"{hours}:0{minutes}");
                }
                else if (minutes >= 10)
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }

            }
        }
    }
}

