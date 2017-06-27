using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SearchForaNumber
{
    class SearchForaNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            var range = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            var index = range[0];
            var indexDelete = range[1];
            var searchNumber = range[2];
            var found = false;
            var selectedNumbers = new List<int>();

            for (int i = 0; i < index; i++)
            {
                selectedNumbers.Add(numbers[i]);
            }

            for (int i = 0; i < indexDelete; i++)
            {
                selectedNumbers.RemoveAt(0);
            }

            for (int i = 0; i < selectedNumbers.Count; i++)
            {
                if (selectedNumbers[i] == searchNumber)
                {
                    found = true;
                }
            }
            if (found)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
