using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            var unit = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles":
                    var kilometers = value * 1.6;
                    Console.WriteLine($"{value} {unit} = {kilometers:f2} kilometers");
                    break;
                case "inches":
                    var centimeters = value * 2.54;
                    Console.WriteLine($"{value} {unit} = {centimeters:f2} centimeters");
                    break;
                case "feet":
                     var centimeters1 = value * 30.0;
                    Console.WriteLine($"{value} {unit} = {centimeters1:f2} centimeters");
                    break;
                case "yards":
                    var meters = value * 0.91;
                    Console.WriteLine($"{value} {unit} = {meters:f2} meters");
                    break;
                case "gallons":
                    var liters = value * 3.8;
                    Console.WriteLine($"{value} {unit} = {liters:f2} liters");
                    break;
                default:
                    break;
            }
        }
    }
}
