using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (char first = (char)97; first < (char)(97 + num); first++)
            {
                for (char second = (char)97; second < (char)(97 + num); second++)
                {
                    for (char third = (char)97; third < (char)(97 + num); third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
