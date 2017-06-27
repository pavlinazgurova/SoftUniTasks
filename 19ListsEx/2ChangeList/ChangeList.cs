using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            var command = Console.ReadLine();

            while (command != "Even" || command != "Odd")
            {
                var operation = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToList();
                switch (operation[0])
                {
                    case "Delete":
                        int index = int.Parse(operation[1]);
                        numbers.RemoveAll(x => x == index);
                        break;
                    case "Insert":
                        int position = int.Parse(operation[2]);
                        int element = int.Parse(operation[1]);
                        numbers.Insert(position, element);
                        break;
                    case "Even":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        break;
                    case "Odd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (command == "Odd" || command == "Even")
                {
                    return;
                }
                
                command = Console.ReadLine();              
            }            
        }
    }
}
