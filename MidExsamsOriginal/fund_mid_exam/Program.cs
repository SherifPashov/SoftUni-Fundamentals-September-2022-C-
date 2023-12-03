using System;
using System.ComponentModel;

namespace fund_mid_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberCity = int.Parse(Console.ReadLine());
            
            decimal finalMoney = 0;

            for (int i = 1; i <= numberCity; i++)
            {
                string nameCity = Console.ReadLine();
                decimal money = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());

                if (i % 3 == 0 && i % 5 !=0)
                {
                    expenses *= 1.5m;
                }
                if (i % 5 ==0 )
                {
                    money *= 0.9m;
                }
                decimal nowCityProfit = money - expenses;
                Console.WriteLine($"In {nameCity} Burger Bus earned {nowCityProfit:f2} leva.");
                finalMoney+=nowCityProfit;
            }
            Console.WriteLine($"Burger Bus total profit: {finalMoney:f2} leva.");
        }
    }
}
