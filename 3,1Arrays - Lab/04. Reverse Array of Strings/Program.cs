using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ")
                .ToArray();
            string[] arrReverse = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrReverse[arr.Length-1-i] = arr[i];
            }
            Console.WriteLine(string.Join(" ",arrReverse));
        }
    }
}
