using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintingTriangle(number);

        }

        static void PrintingTriangle(int number)
        {
            for (int r = 1; r <=  number; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            for (int r = number - 1; r >=1 ; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
