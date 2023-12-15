using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           

            for (int i = 1; i <= number; i++)
            {
                
                int sumNumber = 0;
                int iCopy = i;

                while (iCopy > 0)
                {
                    sumNumber += iCopy % 10;
                    iCopy /= 10;
                }
                if (sumNumber == 5|| sumNumber == 7 || sumNumber == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }
        }
    }
}
