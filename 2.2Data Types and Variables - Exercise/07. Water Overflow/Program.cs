using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLine = int.Parse(Console.ReadLine());
            int sumLitres = 0;
            for (int i = 0; i < numberLine; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                sumLitres += litres;

                if (sumLitres > 255)
                {
                    sumLitres -= litres;
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            Console.WriteLine(sumLitres);
        }
    }
}
