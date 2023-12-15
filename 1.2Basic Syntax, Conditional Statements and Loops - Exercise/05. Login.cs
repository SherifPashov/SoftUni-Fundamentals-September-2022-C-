using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            
            string n = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                n += username[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                string currectPassword = Console.ReadLine();
                if (currectPassword == n)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                
                if (i == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    continue;
                }
                Console.WriteLine($"Incorrect password. Try again.");
            }

        }
    }
}
