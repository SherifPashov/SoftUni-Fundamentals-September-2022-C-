using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char[] input = Console.ReadLine()
                .ToCharArray();
            Dictionary<char , int> keyValuePairs = new Dictionary<char , int>();

            foreach (var charecter in input)
            {
                if (charecter == ' ')
                {
                    continue;
                }
                if (!keyValuePairs.ContainsKey(charecter))
                {
                    keyValuePairs.Add(charecter, 0);
                }
                keyValuePairs[charecter]++;
            }
            foreach (var (key, value) in keyValuePairs)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
