using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberLoop = int.Parse(Console.ReadLine());
            Dictionary<string,string> cars = new Dictionary<string,string>();

            for (int i = 0; i < numberLoop; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string comand = input[0];
                string usermane = input[1];
                

                if (comand == "register")
                {
                    string carNumer = input[2];
                    if (!cars.ContainsKey(usermane))
                    {
                        cars.Add(usermane, carNumer);
                        Console.WriteLine($"{usermane} registered {carNumer} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {cars[usermane]}");
                    }
                }
                else if (comand == "unregister")
                {

                    if (cars.ContainsKey(usermane))
                    {
                        cars.Remove(usermane);
                        Console.WriteLine($"{usermane} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {usermane} not found");
                    }
                }
            }
            foreach (var (name, numberCar) in cars)
            {
                Console.WriteLine($"{name} => {numberCar}");
            }
        }
    }
}
