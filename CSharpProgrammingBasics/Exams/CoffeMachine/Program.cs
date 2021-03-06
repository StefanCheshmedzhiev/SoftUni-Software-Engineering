using System;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drinkType = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberDrinks = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (drinkType == "Espresso")
            {
                if (sugar == "Without")
                {
                    price = 0.90;
                }
                else if (sugar == "Normal")
                {
                    price = 1.0;
                }
                else
                {
                    price = 1.2;
                }
            }
            if (drinkType == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    price = 1.0;
                }
                else if (sugar == "Normal")
                {
                    price = 1.2;
                }
                else
                {
                    price = 1.6;
                }
            }
            if (drinkType == "Tea")
            {
                if (sugar == "Without")
                {
                    price = 0.5;
                }
                else if (sugar == "Normal")
                {
                    price = 0.6;
                }
                else
                {
                    price = 0.7;
                }
            }
            double totalPrice = numberDrinks * price;
            if (sugar == "Without")
            {
                totalPrice *= 0.65;
            }
            if (drinkType == "Espresso" && numberDrinks >= 5)
            {
                totalPrice *= 0.75;
            }
            if (totalPrice > 15)
            {
                totalPrice *= 0.80;
            }
            Console.WriteLine($"You bought {numberDrinks} cups of {drinkType} for {totalPrice:f2} lv.");
        }
    }
}
