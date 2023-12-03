using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> number1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> number2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int nowCount = -1;
            if (number1.Count >= number2.Count)
            {
                for (int i = 0; i < number2.Count; i++)
                {
                    nowCount++;
                    result.Add(number1[i]);
                    result.Add(number2[i]);

                }
                for (int i = nowCount; i < number1.Count; i++)
                {
                   result.Add(number1[i]);
                }
            }
            else if (number2.Count > number1.Count)
            {
                for (int i = 0; i < number1.Count; i++)
                {
                    nowCount+=2;
                    result.Add(number1[i]);
                    result.Add(number2[i]);

                }
                for (int i = nowCount; i < number2.Count; i++)
                {
                    result.Add(number2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }

     
    }
}
