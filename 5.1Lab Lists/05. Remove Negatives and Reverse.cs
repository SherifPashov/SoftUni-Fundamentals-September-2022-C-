using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i]<0)
                {
                    number.RemoveAt(i);
                    i--;
                }
            }
            if (number.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                number.Reverse();
                Console.WriteLine(String.Join(" ",number));
            }
        }
    }
}
