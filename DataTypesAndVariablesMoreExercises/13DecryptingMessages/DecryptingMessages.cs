using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13DecryptingMessages
{
    class DecryptingMessages
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char characters = char.Parse(Console.ReadLine());

                message += (char)(characters + key);
            }
            Console.WriteLine(message);
        }
    }
}
