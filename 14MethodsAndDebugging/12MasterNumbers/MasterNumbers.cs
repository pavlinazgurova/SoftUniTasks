using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var evenDigit = ContainsEvenDigit(num);
            var isPalindromeNumber = IsPalindrome(num);
            var sumOfDigit = divisibleSum(num);

            for (int i = 1; i <= num; i++)
            {
                if (isPalindromeNumber(i) == true && evenDigit(i) == true && sumOfDigit(i) == true)
                {
                    Console.WriteLine($"{i} ");
                }

            }

        }

        static bool IsPalindrome(int num)
        {
            string number = num.ToString();
            var reverse = num.ToString().Reverse().ToArray();
            var smth = string.Join("", reverse);
            if (number == smth)
            {
                return true;
            }
            return false;

        }

        static bool ContainsEvenDigit(int num)
        {
            bool istrue = false;
            string str = num.ToString();
            int number = str.Length;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    istrue = true;
                }
                lastDigit = number / 10;
                number = lastDigit;
            }

            if (!istrue)
            {
                return false;
            }
            return true;
        }

        public static bool divisibleSum(int num)
        {
            string str = num.ToString();
            int sumOfDigits = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sumOfDigits += int.Parse(str[i].ToString());
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
