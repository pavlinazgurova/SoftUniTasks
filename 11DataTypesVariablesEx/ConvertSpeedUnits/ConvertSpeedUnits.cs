using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            ushort time = (ushort)(hours * 3600 + minutes * 60 + seconds);

            float metersPerSec = (float)distance / time;
            float kilometersPerHour = ((float)distance / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)distance / 1609) / ((float)time / 3600);

            Console.WriteLine("{0:0.#######}", metersPerSec);
            Console.WriteLine("{0:0.#######}", kilometersPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHour);


        }
    }
}
