using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());
            string itemName;
            double itemPrice;
            int itemCount;
            var moneyLeft = budget;
            var totalPrice = 0.00;

            for (int i = 1; i <= numberOfItems; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                itemCount = int.Parse(Console.ReadLine());

                if (itemCount == 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                    moneyLeft -= itemPrice * itemCount;
                    totalPrice += itemPrice * itemCount;
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                    moneyLeft -= itemPrice * itemCount;
                    totalPrice += itemPrice * itemCount;
                }
            }
            var diff = Math.Abs(totalPrice - budget);
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Subtotal: ${totalPrice:f2}");
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${totalPrice:f2}");
                Console.WriteLine($"Not enough. We need ${Math.Abs(moneyLeft):f2} more.");
            }
        }
    }
}
