using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrString1 = Console.ReadLine();
            string[] arrArray1 = arrString1
                .Split(" ")
                 .ToArray();

            string arrString2 = Console.ReadLine();
            string[] arrArray2 = arrString2
                .Split(" ")
                .ToArray();


            for (int i = 0; i < arrArray2.Length ; i++)
            {
                string words2 = arrArray2[i];
                for (int l = 0; l < arrArray1.Length; l++)
                {
                    string word1 = arrArray1[l];
                    if (words2 == word1)
                    {
                        Console.Write(word1+ " ");
                    }
                }

            }
        }      
    }
}
