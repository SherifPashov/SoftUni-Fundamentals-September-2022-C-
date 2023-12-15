using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            int Number = int.Parse(Console.ReadLine());
            string result = Slepvane(words, Number);
            Console.WriteLine(result);
        }
        static string Slepvane (string words ,int Number )
        {
            string slepvane = "";
            for(int a = 1; a <= Number; a++)
            {
                slepvane += words;
            }
            return slepvane;
        }
    }
}
