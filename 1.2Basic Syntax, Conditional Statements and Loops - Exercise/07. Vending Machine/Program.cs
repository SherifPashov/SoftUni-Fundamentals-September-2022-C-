using System;
using System.Runtime.CompilerServices;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string coins = Console.ReadLine();
            double sum = 0;

            while (coins != "Start")
            {
                double money = double.Parse(coins);
                if (money == 0.1)
                {
                    sum += money;
                }
                else if (money == 0.2)
                {
                    sum += money;
                }
                else if (money == 0.5)
                {
                    sum += money;
                }
                else if (money == 1)
                {
                    sum += money;
                }
                else if (money == 2)
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                coins = Console.ReadLine();
            }
            string nameOfProduct = Console.ReadLine();
            while (nameOfProduct != "End" )
            {
                switch (nameOfProduct)
                {
                    case "Nuts":
                        if (sum < 2)
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        else
                        {
                            sum -= 2;
                            Console.WriteLine($"Purchased nuts");
                        }
                        break;

                    case "Water":
                        if (sum < 0.7)
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        else
                        {
                            sum -= 0.7;
                            Console.WriteLine($"Purchased water");
                            
                        }
                        break;

                    case "Crisps":
                        if (sum < 1.5)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            
                        }
                        else
                        {
                            sum -= 1.5;
                            Console.WriteLine($"Purchased crisps");
                            
                        }
                        break;

                    case "Soda":
                        if (sum < 0.8)
                        {
                            Console.WriteLine("Sorry, not enough money");
                           
                        }
                        else
                        {
                            sum -= 0.8;
                            Console.WriteLine($"Purchased soda");
                           
                        }
                        break;
                    case "Coke":
                        if (sum < 1)
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        else
                        {
                            sum -= 1;
                            Console.WriteLine($"Purchased coke");
                            
                        }
                        break;

                        default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                nameOfProduct = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }

    }
}
