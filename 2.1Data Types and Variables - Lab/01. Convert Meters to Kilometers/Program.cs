using System;

namespace _2._1Data_Types_and_Variables___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());

            double km = (double)metres / 1000;

            Console.WriteLine($"{km:f2}");
        }
    }
}
