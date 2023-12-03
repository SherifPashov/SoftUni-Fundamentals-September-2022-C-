using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, words.Length);

                string currentword = words[i];
                string nextWord = words[randomIndex];
                words[i] =nextWord;
                words[randomIndex] = currentword;
                
            }
            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
            
    }
}
