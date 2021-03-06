using System;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double priceStatuete = rent * 0.70;
            double priceCatering = priceStatuete * 0.85;
            double priceSound = (priceCatering * 1) / 2;
            double total = rent + priceStatuete + priceCatering + priceSound;
            Console.WriteLine($"{total:f2}");
        }
    }
}
