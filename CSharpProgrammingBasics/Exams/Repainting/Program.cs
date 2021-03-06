using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int razreditelNeeded = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double priceNylon = (nylonNeeded + 2) * 1.50;
            double pricePaint = (paintNeeded + (paintNeeded * 0.10)) * 14.50;
            double priceRazreditel = razreditelNeeded * 5.00;
            double totalProducts = priceNylon + pricePaint + priceRazreditel + 0.40;
            double pricePeople = (totalProducts * 0.30) * workingHours;
            double total = totalProducts + pricePeople;
            Console.WriteLine($"Total expenses: {total:f2} lv.");
        }
    }
}
