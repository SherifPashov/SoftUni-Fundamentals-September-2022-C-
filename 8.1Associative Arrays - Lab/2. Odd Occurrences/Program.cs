using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Dictionary<string, int> contains = new Dictionary<string, int>();

            foreach (var item in input)
            {
                string toLowerCase = item.ToLower();
                if (!contains.ContainsKey(toLowerCase))
                {

                    contains.Add(toLowerCase, 0);
                }
                contains[toLowerCase]++;
            }

            foreach (var item in contains)
            {
                if (item.Value % 2==1)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
