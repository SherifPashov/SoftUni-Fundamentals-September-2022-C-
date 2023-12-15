using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            while (number!="END")
            {
                bool isItPalindrome = PalindromeIntegers(number);
                if (isItPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                number = Console.ReadLine();
            }
        }
        static bool PalindromeIntegers(string number)
        {
            string reverceNumber = null;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reverceNumber += number[i];

            }
            if (number == reverceNumber)
            {
                return true;
            }
            return false;
        }
    }
}
