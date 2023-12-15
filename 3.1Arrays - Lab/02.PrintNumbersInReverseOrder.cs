using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            int[] arr = new int[number];
            for (int i = number - 1; i >= 0; i--)
            {
                int numberArr = int.Parse(Console.ReadLine());
                arr[i] = numberArr;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
