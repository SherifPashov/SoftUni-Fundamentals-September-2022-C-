using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string patern = @"\%(?<customerName>[A-Z][a-z]+)\%([^\||\$|\%|\.]+)?<(?<product>\w+)>([^\||\$|\%|\.]+)?\|(?<quantity>\d+)\|([^\||\$|\%|\.]*?)(?<price>\d+(\.\d+)?)\$";
            //string patern = @"^%(?<customerName>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            Regex regex = new Regex(patern);
            string input;
            double totalIncome = 0;
            while ((input=Console.ReadLine())!="end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string customerName = match.Groups["customerName"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = quantity * price;
                    totalIncome+=totalPrice;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
