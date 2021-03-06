using System;

namespace MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberDays = int.Parse(Console.ReadLine());
            int numberTickets = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int percentForTheCinema = int.Parse(Console.ReadLine());

            double priceTicketsPerDay = numberTickets * priceTicket;
            double incomeWholePeriod = numberDays * priceTicketsPerDay;
            double percentForTheCinema1 = incomeWholePeriod * percentForTheCinema / 100;
            double totalIncome = incomeWholePeriod - percentForTheCinema1;
            Console.WriteLine($"The profit from the movie {name} is {totalIncome:f2} lv.");
        }
    }
}
