using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> listNumber = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int[] boom = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int number = boom[0];
            int pawar = boom[1];

            for (int i = 0; i < listNumber.Count; i++)
            {
                if (listNumber[i] == number)
                {
                    int first =i-pawar;
                    if (first<0)
                    {
                        first= 0;
                    }
                    int last = i+pawar;
                    if (last>=listNumber.Count)
                    {
                        last = listNumber.Count - 1;
                    }

                    for (int m = first; m <= last; m++)
                    {
                        listNumber.RemoveAt(first);
                        
                    }
                    i = -1;
                }
                
            }
            
            Console.WriteLine(listNumber.Sum());

        }
    }
}
