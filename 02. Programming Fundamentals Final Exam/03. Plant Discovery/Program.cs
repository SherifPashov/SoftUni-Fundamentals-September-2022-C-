using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, int> plantRating = new Dictionary<string, int>();
            Dictionary<string, int> plantRating2 = new Dictionary<string, int>();
            

            for (int i = 0; i < n; i++)
            {
                string[] infoPlant = Console.ReadLine()
                    .Split("<->");
                string plant = infoPlant[0];
                int rarity = int.Parse(infoPlant[1]);
                if (!plantRarity.ContainsKey(plant))
                {
                    plantRarity[plant] = 0;
                    plantRating[plant] = 0;
                    plantRating2[plant] = 0;
                }
                plantRarity[plant] += rarity;
            }

            string input;
            while ((input=Console.ReadLine())!= "Exhibition")
            {
                string[] info = input.Split(" ");
                string comand = info[0];
                string plant = info[1];

                if (comand == "Rate:")
                {
                    
                    int rating = int.Parse(info[3]);
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant] += rating;
                        plantRating2[plant]++;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (comand == "Update:")
                {
                    int rarity = int.Parse(info[3]);
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRarity[plant] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (comand == "Reset:")
                {
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant] = 0;
                        plantRating2[plant] = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var (key,value) in plantRarity)
            {
                if (plantRating2[key]!=0)
                {
                    double averageRating = plantRating[key]*1.0 / plantRating2[key];
                    Console.WriteLine($"- {key}; Rarity: {value}; Rating: {averageRating:f2}");
                }
                else
                {
                    Console.WriteLine($"- {key}; Rarity: {value}; Rating: 0.00");
                }
                    
                    
                
            }
        }
    }
}
