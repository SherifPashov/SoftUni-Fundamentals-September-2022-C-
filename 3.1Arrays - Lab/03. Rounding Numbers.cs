using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string arrLine = Console.ReadLine();
            double[] arr = arrLine
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                arr[i] = (int) Math.Round( arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($" => {arr[i]}");
            }
           
                
        }
    }
}
