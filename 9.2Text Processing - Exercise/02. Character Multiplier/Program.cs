using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string word1 = input[0];
            string word2 = input[1];
            Console.WriteLine(Result(word1, word2));
        }

        private static int Result(string word1, string word2)
        {
            int sum = 0;
            if (word1.Length > word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    sum += word1[i] * word2[i];
                }
                for (int k = word2.Length; k < word1.Length; k++)
                {
                    sum += word1[k];
                }
            }
            else
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    sum += word1[i] * word2[i];
                }
                for (int k = word1.Length; k < word2.Length; k++)
                {
                    sum += word2[k];
                }
            }
            return sum;
        }
    }
}
