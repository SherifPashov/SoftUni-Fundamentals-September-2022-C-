using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int copyNumber = inputNumber;
            int sumFactorials = 0;

            while (copyNumber != 0)
            {
                int lastNumber = copyNumber % 10;
                copyNumber /= 10;
                int facturiels = 1;

                for (int i = 1; i <= lastNumber ; i++)
                {
                    facturiels*=i;
                }
                sumFactorials += facturiels;
            }
            if (inputNumber == sumFactorials)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
