using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            var command = Console.ReadLine();

            var list = new List<string>();

            while (command != "stop")
            {
                list.Add(command);

                command = Console.ReadLine();
            }

            for (int i = 0; i < list.Count; i += 2)
            {
                if (list[i + 1].EndsWith("us") || list[i + 1].EndsWith("uk"))
                {
                    list.Remove(list[i]);
                }
                else
                {
                    dict.Add(list[i], list[i + 1]);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            //Console.WriteLine(string.Join(" ", list));
        }
    }
}
