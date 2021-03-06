using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberStatists = int.Parse(Console.ReadLine());
            double priceClotherPerStatist = double.Parse(Console.ReadLine());

            double amountDecor = budget * 0.10;
            double amountClothes = numberStatists * priceClotherPerStatist;
            if (numberStatists > 150)
            {
                amountClothes *= 0.90;
            }
            double total = amountDecor + amountClothes;

            if (budget >= total)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total - budget:f2} leva more.");
            }

        }
    }
}
