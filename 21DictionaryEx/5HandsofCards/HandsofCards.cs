using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HandsofCards
{
    class HandsofCards
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();

            var line = Console.ReadLine();

            while (line != "JOKER")
            {
                var tokens = line.Split(':');

                var name = tokens[0];
                var cards = tokens[1].Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).
                   Select(GetSum)
                   .ToArray();

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<int>();
                }

                dict[name].AddRange(cards);

                line = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                var name = item.Key;
                var cards = item.Value;

                var totalSum = cards.Distinct().Sum();

                Console.WriteLine($"{name}: {totalSum}");
            }


            //var text = Console.ReadLine().
            //    ToLower().
            //    Split(new char[] { '|', ' ', '[', ']', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '.' },
            //    StringSplitOptions.RemoveEmptyEntries).
            //    ToList();

            
        }

       static int GetSum(string card)
        {
            var cardPowers = new Dictionary<string, int>();
            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;

            for (int i = 2; i <= 10; i++)
            {
                cardPowers[i.ToString()] = i;
            }

            var cardsType = new Dictionary<string, int>();
            cardsType["S"] = 4;
            cardsType["H"] = 3;
            cardsType["D"] = 2;
            cardsType["C"] = 1;

            var power = card.Substring(0, card.Length - 1);
            var type = card.Substring(card.Length - 1);
            var value = cardPowers[power] * cardsType[type];

            return value;
        }
    }
}
