using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int pawer = int.Parse(Console.ReadLine());
            double result =Pawer(baseNumber, pawer);
            Console.WriteLine(result);
        }

        static double Pawer(double baseNumber, int pawer)
        {
            if (pawer == 0 || baseNumber ==0)
            {
                return 1;
            }
            double result = 1;
            for (int i = 1; i <= pawer; i++)
            {
                result *= baseNumber;   
            }
           
            return result;
        }
    }

}
