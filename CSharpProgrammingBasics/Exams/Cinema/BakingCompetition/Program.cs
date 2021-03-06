using System;

namespace BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberParticipants = int.Parse(Console.ReadLine());
            int totalCounter = 0;
            double totalSum = 0;
            for (int i = 0; i < numberParticipants; i++)
            {
                string name = Console.ReadLine();
                string input = Console.ReadLine();
                double price = 0;
                int cookies = 0;
                int cakes = 0;
                int waffles = 0;
                while (input != "Stop baking!")
                {
                  
                    switch (input)
                    {
                        case "cookies":
                            int numberCookies = int.Parse(Console.ReadLine());
                            price += (numberCookies * 1.50);
                            cookies += numberCookies;
                            break;
                        case "cakes":
                            int numberCakes = int.Parse(Console.ReadLine());
                            price += (numberCakes * 7.80);
                            cakes += numberCakes;
                            break;
                        case "waffles":
                            int numberWaffles = int.Parse(Console.ReadLine());
                            price += (numberWaffles * 2.30);
                            waffles += numberWaffles;
                            break;
                    }
                    input = Console.ReadLine();
                    
                }
                Console.WriteLine($"{name} baked {cookies} cookies, {cakes} cakes and {waffles} waffles.");
                totalCounter += (cookies + cakes + waffles);
                totalSum += price;
            }
            Console.WriteLine($"All bakery sold: {totalCounter}");
            Console.WriteLine($"Total sum for charity: {totalSum:f2} lv.");
        }
    }
}
