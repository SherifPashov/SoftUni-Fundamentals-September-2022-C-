using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] travel = Console.ReadLine()
                   .Split("||")
                   .ToArray();

            int oilStart = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < travel.Length; i++)
            {
                string[] travelOperation = travel[i].Split(" ").ToArray();
                string comand = travelOperation[0];
               
                if (comand == "Travel")
                {
                   int distance = int.Parse(travelOperation[1]);
                    oilStart -=distance;
                    if (oilStart>=0)
                    {
                        Console.WriteLine($"The spaceship travelled {distance} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (comand == "Enemy")
                {
                    int distance = int.Parse(travelOperation[1]);
                    if (ammunition>=distance)
                    {
                        ammunition -= distance;
                        Console.WriteLine($"An enemy with {distance} armour is defeated.");
                    }
                    else if (ammunition<distance && oilStart-distance*2>=0)
                    {
                        oilStart -= distance * 2;
                        if (oilStart>=0)
                        {
                            Console.WriteLine($"An enemy with {distance} armour is outmaneuvered.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (comand == "Repair")
                {
                    int distance = int.Parse(travelOperation[1]);
                    oilStart +=distance;
                    ammunition+=distance*2;
                    Console.WriteLine($"Ammunitions added: {distance*2}.");
                    Console.WriteLine($"Fuel added: {distance}.");
                }
                else if (comand == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                }
            }
            
        }
    }
}
