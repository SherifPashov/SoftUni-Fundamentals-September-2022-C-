using System;
using System.Text;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] spWord = Console.ReadLine().Split(", ");
            var input = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < spWord.Length; i++)
            {
                string newWord = "";
                for (int k = 0; k < spWord[i].Length; k++)
                {
                    newWord += "*";
                }
               input.Replace(spWord[i], newWord);
              
            }
            Console.WriteLine(input);
           
        }
    }
}
