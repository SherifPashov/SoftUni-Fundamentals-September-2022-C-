using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int numberOfProduct = int.Parse(Console.ReadLine());
            double priceOfProduct =0;

            switch (product)
            {
                case "coffee":
                    priceOfProduct = 1.5;
                    break;
                case "water":
                    priceOfProduct = 1;
                    break;
                case "coke":
                    priceOfProduct = 1.4;
                    break;
                case "snacks":
                    priceOfProduct = 2;
                    break;
            }
            Orders(numberOfProduct, priceOfProduct);
        }
        static void Orders (int numberOfProduct , double priceOfProduct)
        {
            double price = numberOfProduct * priceOfProduct;
            Console.WriteLine($"{price:f2}");
        }
    }
}
