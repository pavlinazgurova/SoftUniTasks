using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();

            var userIP = new SortedDictionary<string, Dictionary<string, int>>();

            while (message != "end")
            {
                var text = message.Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var user = text.Last();
                var ip = text[1];

                //var count = 1;

                if (!userIP.ContainsKey(user))
                {
                    userIP[user] = new Dictionary<string, int>();
                }

                if (!userIP[user].ContainsKey(ip))
                {
                    userIP[user][ip] = 1;
                }
                else
                {
                    userIP[user][ip]++;
                }
                message = Console.ReadLine();
            }

            foreach (var item in userIP)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var ipCount in item.Value)
                {
                    for (int i = 0; i < ipCount.Value; i++)
                    {
                        if (i == ipCount.Value - 1)
                        {
                            Console.WriteLine($"{ipCount.Key} => {ipCount.Value}.");
                        }
                        else
                        {
                            Console.WriteLine($"{ipCount.Key} => {ipCount.Value},");
                        }
                    }
                }
            }
        }
    }
}
