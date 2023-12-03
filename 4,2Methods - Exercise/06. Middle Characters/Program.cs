using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string single = Console.ReadLine();
            MidleCharacters(single);
        }

        private static void MidleCharacters(string single)
        {
            if (single.Length % 2 == 1)
            {
                int index = (int)(single.Length / 2);
                Console.WriteLine(single[index]);
            }
            else
            {
                int index = (int)(single.Length / 2);
                Console.Write(single[index-1]);
                Console.Write(single[index]); //123456  someText
                                              //012345  01234567
            }
        }
    }
}
