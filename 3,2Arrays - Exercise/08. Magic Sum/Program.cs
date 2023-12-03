using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int specialNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int l = i +1; l < arr.Length; l++)
                {
                    int numI=arr[i];
                    int numL=arr[l];
                    if (numI + numL == specialNumber)
                    {


                        Console.WriteLine(numI + " " + numL);
                    }
                }
            }
        }
    }
}
