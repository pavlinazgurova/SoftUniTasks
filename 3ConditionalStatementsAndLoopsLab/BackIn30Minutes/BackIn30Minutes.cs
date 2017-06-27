using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            
            if (minutes >= 30 && hours < 23)
            {
                minutes = minutes - 30;
                if (minutes <= 9)
                {
                    hours++;
                    minutes = minutes - 30;
                    Console.WriteLine($"{hours}:0{minutes}");
                }
                hours++;
                //minutes = minutes - 30;
                Console.WriteLine($"{hours}:{minutes}");
            }

            if (hours == 23)
            {

            }


        }
    }
}
