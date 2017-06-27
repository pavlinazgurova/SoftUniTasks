using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3EnglishNameofLastDigit
{
    class EnglishNameofLastDigit
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            string englishName = GetEnglishName(num);
            Console.WriteLine(englishName);
        }

        static string GetEnglishName(string num)
        {
            //int lastNum = num % 10;

            if (num.EndsWith("1"))
            {
                return "one";
            }
            else if (num.EndsWith("2"))
            {
                return "two";
            }
            else if (num.EndsWith("3"))
            {
                return "three";
            }
            else if (num.EndsWith("4"))
            {
                return "four";
            }
            else if (num.EndsWith("5"))
            {
                return "five";
            }
            else if (num.EndsWith("6"))
            {
                return "six";
            }
            else if (num.EndsWith("7"))
            {
                return "seven";
            }
            else if (num.EndsWith("8"))
            {
                return "eight";
            }
            else if (num.EndsWith("9"))
            {
                return "nine";
            }
            return "zero";
            //switch (lastNum)
            //{
            //    case 1:
            //        return "one";
            //    case 2:
            //        return "two";
            //    case 3:
            //        return "three";
            //    case 4:
            //        return "four";
            //    case 5:
            //        return "five";
            //    case 6:
            //        return "six";
            //    case 7:
            //        return "seven";
            //    case 8:
            //        return "eight";
            //    case 9:
            //        return "nine";
            //    default:
            //        return "zero";
            //}

        }
    }
}
