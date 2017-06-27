using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Substring(0, word.Length - 1);
                Console.WriteLine($"{word}ies");
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh"))
            {                
                Console.WriteLine($"{word}es");
            }
            else
            {                
                Console.WriteLine($"{word}s");
            }
        }
    }
}
