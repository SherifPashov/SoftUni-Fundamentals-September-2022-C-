using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();
            int count = number.Count;
            int countFOR = (number.Count / 2);
            for (int i = 0; i < countFOR; i++)
            {
                number[i] += number[count - 1 - i];
                number.RemoveAt(count - 1 - i);
            }
            Console.WriteLine(String.Join(" ", number));
        }
    }
}
