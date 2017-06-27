using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            string hall;
            var totalPrice = 0.00;
            var pricePerPerson = 0.00;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            ////if (groupSize == 10 && package == "Gold")
            ////{
            ////    hall = "Small Hall";

            ////    totalPrice = (2500 + 750 - (2500 + 750 * 0.90));
            ////    pricePerPerson = totalPrice / groupSize;

            ////    Console.WriteLine($"We can offer you the {hall}");
            ////    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            ////}
            else if (groupSize> 0 && groupSize <= 50)
            {
                hall = "Small Hall";
                
                switch (package)
                {
                    case "normal":
                        totalPrice = (2500 + 500) - (((double)2500 + 500) * 0.05);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    case "Gold":
                        totalPrice = ((2500 + 750) - ((double)2500 + 750) * 0.10);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    case "Platinum":
                        totalPrice = ((2500 + 1000) - ((double)2500 + 1000) * 0.15);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";

                switch (package)
                {
                    case "Normal":
                        totalPrice = (5000 + 500) - (((double)5000 + 500) * 0.05);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    case "Gold":
                        totalPrice = ((5000 + 750) - ((double)5000 + 750) * 0.10);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    case "Platinum":
                        totalPrice = ((5000 + 1000) - ((double)5000 + 1000) * 0.15);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

            else if (groupSize > 100 && groupSize <= 120 )
            {
                hall = "Great Hall";

                switch (package)
                {
                    case "Normal":
                        totalPrice = (7500 + 500) - (((double)7500 + 500) * 0.05);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    case "Gold":
                        totalPrice = ((7500 + 750) - ((double)7500 + 750) * 0.10);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    case "Platinum":
                        totalPrice = ((7500 + 1000) - ((double)7500 + 1000) * 0.15);
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

            
        }
    }
}
