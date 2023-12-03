using System;
using System.Text;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
           

            while (input.IndexOf(word) !=-1)
            {
                input = input.Remove(input.IndexOf(word),word.Length);
            }
            Console.WriteLine(input);
        }
    }
}
