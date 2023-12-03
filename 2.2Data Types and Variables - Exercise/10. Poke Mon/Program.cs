using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pawarN = int.Parse(Console.ReadLine());
            int metres = int.Parse(Console.ReadLine());
            int koaficinetY = int.Parse(Console.ReadLine());
            int n = pawarN;
            int caunter = 0;

            while (n >= metres)
            {
                n-=metres;
                
                caunter++;
                double five = (double)(pawarN * 0.5);
                if (five == n && koaficinetY!=0 && n / koaficinetY!=0)
                {
                    n = (int)(n / koaficinetY);
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(caunter);
        }
    }
}
