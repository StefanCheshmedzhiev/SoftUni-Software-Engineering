using System;

namespace OscarsWeeksInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string type = Console.ReadLine();
            int numberTickets = int.Parse(Console.ReadLine());

            double price = 0;

            if (name == "A Star Is Born")
            {
                if (type == "normal")
                {
                    price = 7.50;
                }
                else if (type == "luxury")
                {
                    price = 10.50;
                }
                else
                {
                    price = 13.50;
                }
            }
            if (name == "Bohemian Rhapsody")
            {
                if (type == "normal")
                {
                    price = 7.35;
                }
                else if (type == "luxury")
                {
                    price = 9.45;
                }
                else
                {
                    price = 12.75;
                }
            }
            if (name == "Green Book")
            {
                if (type == "normal")
                {
                    price = 8.15;
                }
                else if (type == "luxury")
                {
                    price = 10.25;
                }
                else
                {
                    price = 13.25;
                }
            }
            if (name == "The Favourite")
            {
                if (type == "normal")
                {
                    price = 8.75;
                }
                else if (type == "luxury")
                {
                    price = 11.55;
                }
                else
                {
                    price = 13.95;
                }
            }
            double total = numberTickets * price;

            Console.WriteLine($"{name} -> {total:f2} lv.");

        }
    }
}
