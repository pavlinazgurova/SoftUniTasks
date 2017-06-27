using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            var days = years * 365.2422;
            long hours = (long)days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {Math.Truncate(days)} days = {hours} hours = {minutes} minutes ");
        }
    }
}
