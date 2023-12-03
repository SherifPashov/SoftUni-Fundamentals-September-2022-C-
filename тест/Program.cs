using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberKeg = int.Parse(Console.ReadLine());
            string modelMax=null;
            double vMax = 0;
            for (int i = 0; i < numberKeg; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double v = Math.PI * radius * radius * h;
                if (v > vMax)
                {
                  vMax = v;
                    modelMax = model;
                }
            }
            Console.WriteLine(modelMax);
        }
    }
}
