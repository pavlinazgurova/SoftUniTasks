using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseaDrink2
{
    class ChooseaDrink2
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var totalPrice = 0.00;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantity * 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantity * 1.00;
                    break;
                case "SoftUni Student":
                    totalPrice = quantity * 1.70;
                    break;
                default:
                    totalPrice = quantity * 1.20;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
