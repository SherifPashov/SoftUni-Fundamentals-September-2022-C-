using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int numberCopy = number;
            int sumEven = 0;
            int sumOdd = 0;
            sumEven = GerSumEvenDigits(numberCopy, ref sumEven);
            sumOdd = GetSumOddDigits(numberCopy,ref sumOdd);
            int result = GetMultipleOfEvenAndOdds(sumEven, sumOdd);
            Console.WriteLine(result);

        }


         static int GetSumOddDigits(int numberCopy,ref int sumOdd)
        {
            while (numberCopy != 0)
            {
                int lastNumber = numberCopy % 10;
                numberCopy /= 10;
                if (lastNumber % 2 == 1)
                {
                    sumOdd += lastNumber;
                }

            }

            return sumOdd;
        }

         static int GerSumEvenDigits( int numberCopy,ref int sumEven)
         {
            while (numberCopy != 0)
            {
                int lastNumber = numberCopy % 10;
                numberCopy/=10;
                if (lastNumber % 2 == 0)
                {
                    sumEven += lastNumber;
                }

            }

            return sumEven;
         }
        static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            int result = sumEven * sumOdd;
            return result;
        }
    }
}
