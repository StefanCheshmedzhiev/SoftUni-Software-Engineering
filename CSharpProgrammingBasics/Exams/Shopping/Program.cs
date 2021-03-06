using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberVideoCards = int.Parse(Console.ReadLine());
            int numberProcessors = int.Parse(Console.ReadLine());
            int numberRam = int.Parse(Console.ReadLine());

            double priceVideoCards = numberVideoCards * 250;
            double priceProcessor = (priceVideoCards * 0.35) * numberProcessors;
            double priceRam = (priceVideoCards * 0.10) * numberRam;
            double totalExpences = priceVideoCards + priceProcessor + priceRam;
            if (numberVideoCards > numberProcessors)
            {
                totalExpences *= 0.85;
            }
            if (budget >= totalExpences)
            {
                Console.WriteLine($"You have {budget - totalExpences:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalExpences - budget:f2} leva more!");
            }

        }
    }
}
