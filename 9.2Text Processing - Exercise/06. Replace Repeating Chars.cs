using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.Write(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i-1])
                {
                    continue;
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
