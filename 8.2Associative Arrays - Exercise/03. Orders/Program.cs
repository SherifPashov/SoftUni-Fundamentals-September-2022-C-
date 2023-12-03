using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string,List<double>> products = new Dictionary<string,List<double>>();

            while (input != "buy")
            {
                string[] infoInput = input
                    .Split()
                    .ToArray();
                string product = infoInput[0];
                double price = double.Parse(infoInput[1]);
                double quantity = double.Parse(infoInput[2]);
                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(quantity);
                }
                else
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }
                input = Console.ReadLine();
            }
            foreach (var (key,value) in products)
            {
                Console.WriteLine($"{key} -> {value[0] * value[1]:f2}");
            }
        }
    }
}
