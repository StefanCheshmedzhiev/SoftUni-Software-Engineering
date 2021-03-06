using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredIncome = double.Parse(Console.ReadLine());
            string cocktail = Console.ReadLine();
            double totalIncome = 0.0;
            while (cocktail != "Party!")
            {
                int numberCocktails = int.Parse(Console.ReadLine());
                double priceOrder = cocktail.Length * numberCocktails;
                if (priceOrder % 2 != 0)
                {
                    priceOrder *= 0.75;
                }
                totalIncome += priceOrder;
                
                if (totalIncome >= desiredIncome)
                {
                    break;
                }
                cocktail = Console.ReadLine();
            }
            if (totalIncome >= desiredIncome)
            {
                Console.WriteLine("Target acquired.");
                Console.WriteLine($"Club income - {totalIncome} leva.");
            }
            else
            {
                Console.WriteLine($"We need {desiredIncome - totalIncome:f2} leva more.");
                Console.WriteLine($"Club income - {totalIncome:f2} leva.");
            }
        }
    }
}
