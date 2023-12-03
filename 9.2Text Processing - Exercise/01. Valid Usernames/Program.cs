using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            foreach (string word in input)
            {
                if (word.Length > 3 && word.Length <= 16)
                {
                    bool vailidWord = true;
                    foreach (char currChar in word)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar =='-' || currChar =='_'))
                        {
                            vailidWord = false;
                            break;
                        }
                    }
                    if (vailidWord)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
