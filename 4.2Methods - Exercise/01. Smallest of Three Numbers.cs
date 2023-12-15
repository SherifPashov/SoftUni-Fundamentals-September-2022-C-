using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int minValue = minValueMethod(first, second, third);
                Console.WriteLine(minValue);
        }
        static int minValueMethod(int first, int second, int third)
        {
            int minValue = int.MaxValue;
            if (first < minValue)
            {
                minValue = first;
            }
            if (second < minValue)
            {
                minValue = second;
            }
            if (third < minValue)
            {
                minValue = third;
            }
            return minValue;
        }

    }
}
