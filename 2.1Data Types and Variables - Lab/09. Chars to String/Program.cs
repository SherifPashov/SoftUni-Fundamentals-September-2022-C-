using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string charABC = first.ToString() + second.ToString() + third.ToString();
            Console.WriteLine(charABC);

        }
    }
}
