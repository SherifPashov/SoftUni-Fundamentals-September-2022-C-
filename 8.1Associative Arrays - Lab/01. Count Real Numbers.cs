using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            SortedDictionary<int, int> result = new SortedDictionary<int, int>();
            foreach (var number in input)
            {
                if (!result.ContainsKey(number))
                {
                    result.Add(number,0);
                }
                result[number]++;
            }

            foreach (var (key,value) in result)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
