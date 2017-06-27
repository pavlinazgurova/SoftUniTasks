using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long amount = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filtered = (long)Math.Ceiling((double)amount * (double)filterFactor / 100.0);
            long totalFilterTime = filterTime * amount;
            long upload = filtered * uploadTime;


            long totalaTime = totalFilterTime + upload;

            Console.WriteLine(TimeSpan.FromSeconds(totalaTime).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));           
        }
    }
}

