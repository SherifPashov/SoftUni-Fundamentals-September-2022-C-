using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            sumOfDigitsIsDivisidleBy8(number);


        }

        private static void sumOfDigitsIsDivisidleBy8(int number)
        {
            for (int i = 8; i <= number; i++)
            {
                int numberCopyI = i;
                int sum = 0;
                bool oneOdd = false;
                while (numberCopyI != 0)
                {
                    int result = numberCopyI % 10;
                    
                    if (result%2==1)
                    {
                        oneOdd = true;
                    }
                    sum += result;
                    numberCopyI /= 10;
                }
                if (sum % 8 == 0 && sum != 0 && oneOdd)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
