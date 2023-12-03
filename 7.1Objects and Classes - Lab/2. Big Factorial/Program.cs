using System;
using System.Numerics;

namespace _2._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberFactorial = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= numberFactorial; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
