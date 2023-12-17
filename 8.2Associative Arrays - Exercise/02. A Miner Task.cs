using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourse = Console.ReadLine();
            Dictionary<string, int> miner = new Dictionary<string, int>();

            while (resourse!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!miner.ContainsKey(resourse))
                {
                    miner.Add(resourse, 0);
                }
                miner[resourse] += quantity;

                resourse = Console.ReadLine();
            }
            foreach (var (key,value) in miner)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
