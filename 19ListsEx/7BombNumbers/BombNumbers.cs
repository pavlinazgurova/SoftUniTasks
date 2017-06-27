using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            var bombPower = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            var bomb = bombPower[0];
            var power = bombPower[1];
            var right = 0;
            var left = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    right = i + power;
                    left = i - power;
                    int  numsToDelete;
                    if (right > numbers.Count)
                    {
                        var num = numbers.Count - 1;
                        numsToDelete = num - left + 1;
                        numbers.RemoveRange(left, numsToDelete);
                    }
                    else
                    {
                        numsToDelete = right - left + 1;
                        numbers.RemoveRange(left, numsToDelete);
                    }
                    
                    i = -1;            
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
