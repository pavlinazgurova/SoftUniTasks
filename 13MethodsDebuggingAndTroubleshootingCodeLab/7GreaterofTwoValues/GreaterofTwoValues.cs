using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7GreaterofTwoValues
{
    class GreaterofTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int max = GetMaxInt(first, second);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char first1 = char.Parse(Console.ReadLine());
                    char second1 = char.Parse(Console.ReadLine());
                    char max1 = GetMaxChar(first1, second1);
                    Console.WriteLine((char)max1);
                    break;
                case "string":
                    string first2 = Console.ReadLine();
                    string second2 = Console.ReadLine();
                    string max2 = GetMaxString(first2, second2);
                    Console.WriteLine(max2);
                    break;
                default:
                    break;
            }
        }

        static int GetMaxInt(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }

        static char GetMaxChar(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }

        static string GetMaxString(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            return second;
        }
    }
}
