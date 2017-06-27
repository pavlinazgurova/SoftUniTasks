using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            var days = years * 365.2422;
            int hours = (int)days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            decimal nanoseconds = Math.Abs(microseconds * 1000m);

            Console.WriteLine($"{centuries} centuries = {years} years = {Math.Truncate(days)} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds ");

        }
    }
}
