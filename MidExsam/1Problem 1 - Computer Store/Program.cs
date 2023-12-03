using System;

namespace _1Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOrprice = Console.ReadLine();
            decimal price = 0;
            decimal priceTaxes = 0;


            while (nameOrprice != "special" && nameOrprice != "regular")
            {
                decimal conver = decimal.Parse(nameOrprice);
                if (conver < 0)
                {
                    Console.WriteLine("Invalid price!");

                }
                else
                {
                    price += conver;
                    priceTaxes += conver * 1.2m;

                }
                nameOrprice = Console.ReadLine();


            }
            if ((nameOrprice == "special" || nameOrprice == "regular") && price == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {price:F2}$");
                Console.WriteLine($"Taxes: {price * 0.2m:f2}$");
                Console.WriteLine("-----------");
                if (nameOrprice == "special")
                {
                    priceTaxes *= 0.9m;

                }
                Console.WriteLine($"Total price: {priceTaxes:f2}$");
            }
        }
    }
}
