using System;

namespace FilmPremier
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            string package = Console.ReadLine();
            int numberTickets = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (projection == "John Wick")
            {
                if (package == "Drink")
                {
                    price = 12;
                }
            }
            else if (projection == "Star Wars")
            {
                if (package == "Drink")
                {
                    price = 18;
                }
            }
            else 
            {
                if (package == "Drink")
                {
                    price = 9;
                }
            }
            if (projection == "John Wick")
            {
                if (package == "Popcorn")
                {
                    price = 15;
                }
            }
            else if (projection == "Star Wars")
            {
                if (package == "Popcorn")
                {
                    price = 25;
                }
            }
            else
            {
                if (package == "Popcorn")
                {
                    price = 11;
                }
            }
            if (projection == "John Wick")
            {
                if (package == "Menu")
                {
                    price = 19;
                }
            }
            else if (projection == "Star Wars")
            {
                if (package == "Menu")
                {
                    price = 30;
                }
            }
            else
            {
                if (package == "Menu")
                {
                    price = 14;
                }
            }
            double totalPrice = numberTickets * price;
            if (projection == "Star Wars" && numberTickets >= 4)
            {
                totalPrice *= 0.70;
            }
            else if (projection == "Jumanji" && numberTickets == 2)
            {
                totalPrice *= 0.85;
            }
            Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
        }
    }
}
