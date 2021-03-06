using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberNights = int.Parse(Console.ReadLine());
            double unitPricePerNight = double.Parse(Console.ReadLine());
            int percentAddCosts = int.Parse(Console.ReadLine());
            if (numberNights > 7)
            {
                unitPricePerNight *= 0.95;
            }
            double priceNights = numberNights * unitPricePerNight;
            double additionalCosts = budget * (percentAddCosts / 100.0);
            double totalCosts = priceNights + additionalCosts;
            if (budget >= totalCosts)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalCosts:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalCosts - budget:f2} leva needed.");
            }
        }
    }
}
