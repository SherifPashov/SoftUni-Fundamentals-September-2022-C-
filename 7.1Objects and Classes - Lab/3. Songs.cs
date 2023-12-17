using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _3._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Song> songes = new List<Song>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("_");
                string typeSong = input[0];
                string songName = input[1];
                string songTime = input[2];
                Song song1 = new Song(typeSong, songName, songTime);
                songes.Add(song1);
            }
            string list = Console.ReadLine();
            for (int i = 0; i < songes.Count; i++)
            {
                Song song2 = songes[i];
                if (list == "all")
                {
                    Console.WriteLine(song2.Name);
                }
                else if (list == song2.TypeList)
                {
                    Console.WriteLine(song2.Name);
                }
            }
        }
        public class Song
        {
            public Song(string typelist, string name, string time)
            {
                TypeList=typelist;
                Name=name;
                Time=time;
            }
            
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
            
        }
    }
}
