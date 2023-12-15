using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstWord = char.Parse(Console.ReadLine());
            char secondWord = char.Parse(Console.ReadLine());
            firstCharbetweenSecondChar(firstWord, secondWord);
        }

        private static void firstCharbetweenSecondChar(char firstWord, char secondWord)
        {
            int start = (int)firstWord;
            int end = (int)secondWord;
            if (end<start)
            {
                int save = start;
                start = end;
                end = save;
            }
            for (int i = start + 1; i < end; i++)
            {
                char convert = (char)i;
                Console.Write(convert + " ");
            }
        }
    }
}
