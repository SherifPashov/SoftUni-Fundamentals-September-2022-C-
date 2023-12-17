using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem_3___The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> pieceComposer = new Dictionary<string, string>();
            Dictionary<string, string> pieceKey = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split("|");
                string piece = cmd[0];
                string composer = cmd[1];
                string key = cmd[2];
                pieceComposer.Add(piece, composer);
                pieceKey.Add(piece, key);

            }
            string input;
            while ((input=Console.ReadLine())!="Stop")
            {
                string[] info = input.Split("|");
                string comand = info[0];
                if (comand == "Add")
                {

                    string piece = info[1];
                    string composer = info[2];
                    string key = info[3];
                    if (!pieceComposer.ContainsKey(piece))
                    {
                        pieceComposer.Add(piece, composer);
                        pieceKey.Add(piece, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    
                }
                else if (comand == "Remove")
                {
                    string piece = info[1];
                   
                    if (pieceComposer.ContainsKey(piece))
                    {
                        pieceComposer.Remove(piece);
                        pieceKey.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    
                }
                else if (comand == "ChangeKey")
                {
                    string piece = info[1];
                    string key = info[2];
                    if (pieceKey.ContainsKey(piece))
                    {
                        pieceKey[piece] = key;
                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            foreach (var (piece,composer) in pieceComposer)
            {
                Console.WriteLine($"{piece} -> Composer: {composer}, Key: {pieceKey[piece]}");
            }
        }
    }
}
