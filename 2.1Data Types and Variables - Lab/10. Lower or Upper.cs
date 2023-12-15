using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            int ASCII = (int)character;
            if (ASCII >= 65 && ASCII <=90 )
            {
                Console.WriteLine("upper-case");
            }
            else if (ASCII >= 97 && ASCII <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
