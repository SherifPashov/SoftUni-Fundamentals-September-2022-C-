﻿using System;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 ==0)
                .ToArray();
            Console.WriteLine(String.Join("\n",input));
        }
    }
}
