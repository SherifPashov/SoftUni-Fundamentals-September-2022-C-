using System;

namespace Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr =new int[number];
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int numberPeolple = int.Parse(Console.ReadLine());
                sum += numberPeolple;
                arr[i] = numberPeolple;
            }
            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine(sum);
        }
    }
}
