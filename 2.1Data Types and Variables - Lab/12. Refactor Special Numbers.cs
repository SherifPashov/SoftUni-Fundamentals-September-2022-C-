﻿using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kolkko = int.Parse(Console.ReadLine());
            int obshto = 0;
            int takova = 0;
            bool toe = false;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                takova = ch;
                while (ch > 0)
                {
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                string tf;
                if (toe)
                {
                    tf = "True";
                }
                else
                {
                    tf = "False";
                }
                    Console.WriteLine($"{takova} -> {tf}");
                    obshto = 0;
                    ch = takova;
                
                
            }

        }
    }
}
