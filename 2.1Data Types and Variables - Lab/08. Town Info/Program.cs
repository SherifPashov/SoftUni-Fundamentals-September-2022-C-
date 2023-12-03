using System;
using System.Numerics;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string city = Console.ReadLine();
            BigInteger population = BigInteger.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {city} has population of {population} and area {area} square km.");
        }
    }
}
