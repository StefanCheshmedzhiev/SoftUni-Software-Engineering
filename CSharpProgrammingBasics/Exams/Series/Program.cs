using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberSeries = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 0; i < numberSeries; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if (name == "Thrones")
                {
                    price *= 0.50;
                }
                if (name == "Lucifer")
                {
                    price *= 0.60;
                }
                if (name == "Protector")
                {
                    price *= 0.70;
                }
                if (name == "TotalDrama")
                {
                    price *= 0.80;
                }
                if (name == "Area")
                {
                    price *= 0.90;
                }
                totalPrice += price;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {budget - totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {totalPrice - budget:f2} lv. more to buy the series!");
            }
        }
    }
}
