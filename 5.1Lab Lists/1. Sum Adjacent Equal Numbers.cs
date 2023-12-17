using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List <double> number = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();
            for (int i = 0; i < number.Count; i++)
            {
                if (number.Count - 1 == i)
                {
                    break;
                }
                if (number[i] == number[i+1])
                {
                    number[i]+=number[i+1];
                    number.RemoveAt(i + 1);
                    i=-1;
                }
               
            }
            Console.WriteLine(String.Join(" ", number));
        }
    }
}
