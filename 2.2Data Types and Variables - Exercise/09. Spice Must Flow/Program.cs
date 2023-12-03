using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startedYield = int.Parse(Console.ReadLine());
            int days = 0;
            int yield = 0;

            while (startedYield >= 100)
            {
                days++;
                yield += startedYield - 26;
                startedYield -= 10;
                if (startedYield <100)
                {
                    yield -= 26;
                }
                
            }
            Console.WriteLine(days);
            Console.WriteLine(yield);
        }
    }
}
