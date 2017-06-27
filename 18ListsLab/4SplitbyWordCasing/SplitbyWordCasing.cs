using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SplitbyWordCasing
{
    class SplitbyWordCasing
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().
                Split(new char[] { '|', ' ', '[', ']', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '.' }, StringSplitOptions.RemoveEmptyEntries).
                ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixed = new List<string>();

            

            foreach (var word in text)
            {
                bool isUpper = true;
                bool isLower = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        isLower = false;
                    }
                    else if (char.IsLower(word[i]))
                    {
                        isUpper = false;
                    }
                    else
                    {
                        isLower = false;
                        isUpper = false;
                    }
                }
                if (isLower)
                {
                    lowerCase.Add(word);
                }
                else if (isUpper)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
