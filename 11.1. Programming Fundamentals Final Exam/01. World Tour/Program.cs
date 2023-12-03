using System;
using System.Reflection;
using System.Text;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stops = new StringBuilder(Console.ReadLine());

            string input;
            while ((input=Console.ReadLine())!="Travel")
            {
                string[] info = input.Split (':');
                string comand = info[0];
                if (comand == "Add Stop")
                {
                    int index = int.Parse (info[1]);
                    string str = info[2];

                    if (index>=0 && index< stops.Length)
                    {
                        stops = stops.Insert(index, str);
                    }
                    Console.WriteLine(stops);
                    
                }
                else if (comand == "Remove Stop")
                {
                    int startIndex = int.Parse(info[1]);
                    int lastIndex = int.Parse(info[2]);
                    if (startIndex >= 0 && startIndex < stops.Length && lastIndex>=0 && lastIndex< stops.Length)
                    {
                        stops = stops.Remove(startIndex, lastIndex - startIndex + 1);
                    }
                    Console.WriteLine(stops);
                }
                else if (comand =="Switch")
                {
                    string oldString = info[1];
                    string newString = info[2];
                    stops = stops.Replace(oldString, newString);
                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
