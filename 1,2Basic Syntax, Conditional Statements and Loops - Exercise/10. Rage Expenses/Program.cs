using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostCount = int.Parse(Console.ReadLine());
            double priceForHeadset = double.Parse(Console.ReadLine());
            double priceForMouse = double.Parse(Console.ReadLine());
            double priceForKeyboard = double.Parse(Console.ReadLine());
            double priceForDisplay = double.Parse(Console.ReadLine());

            int distroyHeadset = (int)lostCount / 2;
            int distroyMouse = (int)lostCount / 3;
            int distroyKeyboard = (int)lostCount / 6;
            int distroyDisplay = (int)lostCount / 12;

            double priceDistroy = (priceForHeadset * distroyHeadset)+(priceForMouse * distroyMouse) + (priceForKeyboard * distroyKeyboard) + (priceForDisplay * distroyDisplay);
            Console.WriteLine($"Rage expenses: {priceDistroy:f2} lv.");


        }
    }
}
