using System;
using System.Numerics;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());
            int years = centures * 100;
            uint days = (uint)( (decimal)365.2422 * years);
            BigInteger hours =(BigInteger) days * 24;
            BigInteger minutes =(BigInteger) hours * 60;

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
