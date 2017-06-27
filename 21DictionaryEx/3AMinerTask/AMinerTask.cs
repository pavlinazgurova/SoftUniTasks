using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, long>();

            var command = Console.ReadLine();

            var list = new List<string>();
            
            while (command != "stop")
            {
                list.Add(command);

                command = Console.ReadLine();
            }

            for (int i = 0; i < list.Count; i+=2)
            {
                if (dict.ContainsKey(list[i]))
                {
                    dict[list[i]] += long.Parse(list[i + 1]);
                }
                else
                {
                    dict.Add(list[i], long.Parse(list[i + 1]));
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
