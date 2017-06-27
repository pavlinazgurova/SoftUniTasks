using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var rounds = 0;

            var leftDamagePesho = 0;
            var leftDamageGosho = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    if (i == 1)
                    {
                        leftDamageGosho = 100 - peshoDamage;
                        rounds++;                       
                    }
                    else 
                    {
                        leftDamageGosho -= peshoDamage;
                        rounds++;
                    }
                    if (leftDamageGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {rounds}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {leftDamageGosho} health.");
                }
                else if (i % 2 == 0)
                {
                    if (i == 2)
                    {
                        leftDamagePesho = 100 - goshoDamage;
                        rounds++;       
                    }
                    else
                    {
                        leftDamagePesho -= goshoDamage;
                        rounds++;
                    }
                    if (leftDamagePesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {rounds}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {leftDamagePesho} health.");
                }
                if (i % 3 == 0)
                {
                    leftDamagePesho += 10;
                    leftDamageGosho += 10;
                }
            }
        }
    }
}
