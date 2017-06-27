using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            var beatsPerMinute = int.Parse(Console.ReadLine());
            var numberOfBeats = int.Parse(Console.ReadLine());

            var bar = (double)numberOfBeats / 4.00;

            double secondsForOneBeat = 60 / (double)beatsPerMinute;
            double totalSeconds = secondsForOneBeat * numberOfBeats;
            int minutes = (int)totalSeconds / 60;
            int seconds = (int)totalSeconds % 60;
            Console.WriteLine($"{Math.Round(bar, 1)} bars - {minutes}m {seconds}s");
        }
    }
}
