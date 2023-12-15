using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstNumber = int.Parse(Console.ReadLine());
           int secondNumber = int.Parse(Console.ReadLine());

            BigInteger firstFactorial = Facturial(firstNumber);
            BigInteger secondFacturial=Facturial(secondNumber);
            double result = FirstNumberDivisionSecondNumber(firstFactorial,secondFacturial);
            Console.WriteLine($"{result:f2}");
        }
        static BigInteger Facturial(int number)
        {
            BigInteger facturial = 1;
            for (int i = 1; i <= number; i++)
            {
                facturial *= i;
            }
            return facturial;
        }
        static double FirstNumberDivisionSecondNumber(BigInteger first, BigInteger second)
        {
            double firstDouble = (double)first;
            double secondDouble = (double)second;
            double result = firstDouble / secondDouble;
            return result;
        }
    }
}
