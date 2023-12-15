using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberSnowbals = int.Parse(Console.ReadLine());

            
            int bestTime = 0;
            int bestSnow = 0;
            int bestQuality = 0;
            BigInteger bestValue =0;

            for (int i = 0; i < numberSnowbals; i++)
            {
                int snowSnowballs = int.Parse(Console.ReadLine());
                int timeSnowbals = int.Parse(Console.ReadLine());
                int snowballsQualiti = int.Parse(Console.ReadLine());

                
                BigInteger snowballValue = BigInteger.Pow((snowSnowballs / timeSnowbals), snowballsQualiti);
              
                if (bestValue <= snowballValue)
                {
                   
                    bestSnow = snowSnowballs;
                    bestTime = timeSnowbals;
                    bestValue = snowballValue;
                    bestQuality = snowballsQualiti;

                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
            


        }
    }
}
