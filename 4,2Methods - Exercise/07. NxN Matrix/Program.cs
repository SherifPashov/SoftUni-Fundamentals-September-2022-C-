using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NxMMatrix(number);
        }

        private static void NxMMatrix(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int m = 1; m <= number; m++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
