using System;

namespace MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int numberDays = int.Parse(Console.ReadLine());

            double price = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    price = 45000;
                }
                else if (season == "Summer")
                {
                    price = 40000;
                }
            }
            if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    price = 17000;
                }
                else if (season == "Summer")
                {
                    price = 12500;
                }
            }
            if (destination == "London")
            {
                if (season == "Winter")
                {
                    price = 24000;
                }
                else if (season == "Summer")
                {
                    price = 20250;
                }
            }
            double totalPrice = numberDays * price;
            if (destination == "Dubai")
            {
                totalPrice *= 0.70;
            }
            else if (destination == "Sofia")
            {
                totalPrice *= 1.25;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
