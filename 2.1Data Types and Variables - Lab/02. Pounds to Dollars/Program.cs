using System;
using System.Text;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolars = double.Parse(Console.ReadLine());

            double lv = dolars * 1.31;
            Console.WriteLine($"{lv:f3}");
        }
    }
}
