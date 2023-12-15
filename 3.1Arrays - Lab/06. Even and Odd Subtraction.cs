using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEven += arr[i];
                }
                else if (arr[i] % 2 == 1)
                {
                    sumOdd += arr[i];
                }
            }
            int result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}
