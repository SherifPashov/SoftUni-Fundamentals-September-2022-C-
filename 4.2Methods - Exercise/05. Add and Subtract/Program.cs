using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum =SumFirstAndSecondNumber(first, second);
            int differense = DifferenseFirestAndSecond(sum, third);
            Console.WriteLine(differense);
        }

        private static int SumFirstAndSecondNumber(int first, int second)
        {
            return  first + second;
        }
        static int DifferenseFirestAndSecond(int sum, int third)
        {
            return sum - third;
        }
    }
}
