using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilogramsLemons = double.Parse(Console.ReadLine());
            double kilogramsSugar = double.Parse(Console.ReadLine());
            double litersWater = double.Parse(Console.ReadLine());

            double quantityLemonJuiceMl = kilogramsLemons * 980;
            double totalQuantityLemonade = quantityLemonJuiceMl + litersWater * 1000 + (kilogramsSugar * 0.30);
            double cups = Math.Floor(totalQuantityLemonade / 150);
            double moneyEarned = cups * 1.20;
            Console.WriteLine($"All cups sold: {cups}");
            Console.WriteLine($"Money earned: {moneyEarned:f2}");
                
        }
    }
}
