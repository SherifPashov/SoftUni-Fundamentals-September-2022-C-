using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();

            int caunt = movieCount(word);

            Console.WriteLine(caunt);
        }

        private static int movieCount(string word)
        {
            int caunt = 0;
            for (int i = 0; i < word.Length; i++)
            {

                //a, e, i, o, u, and sometimes y).
                switch (word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        caunt++;
                        break;
                }

            }

            return caunt;
        }

    }
}
