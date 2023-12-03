using System;
using System.Collections.Generic;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool between6And10Character = Between6And10Character(password);
            bool isLettersAndDigits = IsLettersAndDigits(password);
            bool mustHaveALeast2Digits = MustHaveALeast2Digits(password);

            if (between6And10Character && isLettersAndDigits && mustHaveALeast2Digits)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool Between6And10Character(string password)
        {
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }

        static bool IsLettersAndDigits(string password)
        {

            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }
            return true;
        }
        static bool MustHaveALeast2Digits(string password)
        {
            int count = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    count++;
                }
            }

            if (!(count >=2))
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }
    }
}
