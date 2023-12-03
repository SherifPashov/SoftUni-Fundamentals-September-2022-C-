using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"^>>(?<name>[A-Za-z]+)<<(?<price>(\d+(\.\d+)?))!(?<quantity>(\d+)?)$";
            Regex regex = new Regex(patern);

            double spendMoney = 0;
            List<string>lst = new List<string>();

            string input = Console.ReadLine();

            while (input!="Purchase")
            {
                Match match = Regex.Match(input, patern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);

                    lst.Add(name);
                    spendMoney += price* quantity;
                }

                input = Console.ReadLine();
            }
            
                Console.WriteLine("Bought furniture:");
                foreach (var name in lst)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine($"Total money spend: {spendMoney:f2}");
            
            
        }
    }
}
