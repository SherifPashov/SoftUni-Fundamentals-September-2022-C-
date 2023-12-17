using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            var charString = new StringBuilder();
            var numberString = new StringBuilder();
            var symbolString = new StringBuilder();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    charString.Append(input[i]);
                }
                else if (char.IsNumber(input[i]))
                {
                    numberString.Append(input[i]);
                }
                else
                {
                    symbolString.Append(input[i]);
                }
            }
            Console.WriteLine(numberString);
            Console.WriteLine(charString);
            Console.WriteLine(symbolString);
        }
    }
}
