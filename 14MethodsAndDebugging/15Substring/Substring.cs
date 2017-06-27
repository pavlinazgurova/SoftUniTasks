using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            string matchedString = string.Empty;            
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;

                    int endIndex = jump;

                    if (endIndex >= (text.Length - i))
                    {
                        matchedString = text.Substring(i, text.Length - i);
                    }
                    else
                    {
                        matchedString = text.Substring(i, endIndex + 1);
                    }
                    
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
