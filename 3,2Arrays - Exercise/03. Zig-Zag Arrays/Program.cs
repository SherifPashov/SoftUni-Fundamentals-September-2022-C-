using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr1 = new int[number];
            int[] arr2 = new int[number];

            for (int i = 1; i <= number; i++)
            {
                string s = Console.ReadLine();
                string[] arr3 = s
                .Split(" ")
                .ToArray();
                int num0 = int.Parse(arr3[0]);
                int num1 = int.Parse(arr3[1]);

                if (i%2 == 1)
                {
                    arr1[i-1] = num0;
                    arr2[i-1] = num1;
                }
                else if (i%2 == 0)
                {
                    arr1[i - 1]=num1;
                    arr2[i - 1] = num0;
                }

                
            }
            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
