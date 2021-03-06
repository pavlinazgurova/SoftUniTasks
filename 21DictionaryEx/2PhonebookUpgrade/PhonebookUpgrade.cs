﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

            var list = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToList();

            while (list[0] != "END")
            {
                if (list[0] == "S")
                {
                    if (phonebook.ContainsKey(list[1]))
                    {
                        Console.WriteLine($"{list[1]} -> {phonebook[list[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {list[1]} does not exist.");
                    }
                }

                if (list[0] == "A")
                {
                    if (phonebook.ContainsKey(list[1]))
                    {
                        phonebook[list[1]] = list[2];
                    }
                    else
                    {
                        phonebook.Add(list[1], list[2]);
                    }

                }

                if (list[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                list = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToList();
            }

        }
    }
}
