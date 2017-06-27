using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            var balance = double.Parse(Console.ReadLine());
            var games = Console.ReadLine();
            var Break = "Game Time";
            var balaceLeft = balance;
            while (games != Break)
            {
                switch (games)
                {
                    case "OutFall 4":
                        if (balaceLeft < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balaceLeft -= 39.99;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        break;
                    case "CS: OG":
                        if (balaceLeft < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balaceLeft -= 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }

                        break;
                    case "Zplinter Zell":
                        if (balaceLeft < 19.99)
                        {
                            Console.WriteLine("Too Expensive");

                        }
                        else
                        {
                            balaceLeft -= 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }

                        break;
                    case "Honored 2":
                        if (balaceLeft < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balaceLeft -= 59.99;
                            Console.WriteLine("Bought Honored 2");
                        }

                        break;
                    case "RoverWatch":
                        if (balaceLeft < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balaceLeft -= 29.99;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balaceLeft < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balaceLeft -= 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }

                        break;
                    default:
                        break;
                }

                if (games != "OutFall 4" && games != "CS: OG" && games != "Zplinter Zell" && games != "Honored 2" && games != "RoverWatch" && games != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }

                if (balaceLeft <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                games = Console.ReadLine();
            }
            if (balaceLeft > 0)
            {
                Console.WriteLine($"Total spent: ${(balance - balaceLeft):f2}. Remaining: ${balaceLeft:f2}");
            }
        }
            
    }
}