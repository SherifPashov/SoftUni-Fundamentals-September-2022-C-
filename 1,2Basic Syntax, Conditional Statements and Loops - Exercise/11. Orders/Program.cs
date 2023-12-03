using System;
using System.Diagnostics;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n =int.Parse(Console.ReadLine());
            double allMoney = 0;

            for (int i = 0; i < n; i++)
            {
                double priceForCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double numberCapsule = double.Parse(Console.ReadLine());

                double moneyForOneReseive = ((days * numberCapsule) * priceForCapsule);
                allMoney+=moneyForOneReseive;
                Console.WriteLine($"The price for the coffee is: ${ moneyForOneReseive:f2}");
               
            }
            Console.WriteLine($"Total: ${allMoney:f2}");
        }
    }
}
