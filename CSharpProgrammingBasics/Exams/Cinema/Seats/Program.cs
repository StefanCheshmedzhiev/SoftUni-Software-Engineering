using System;

namespace Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTickets = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberTickets; i++)
            {
                string ticket = Console.ReadLine();
                string seats = "";
                if (ticket.Length == 4)
                {
                    if (ticket[0] >= 'A' && ticket[0] <= 'Z')
                    {
                        seats += ticket[0];
                    }
                    else
                    {
                        seats += ticket[3];
                    }
                        seats += ticket[1];
                        seats += ticket[2];
                   
                }
                if (ticket.Length == 5 || ticket.Length == 6)
                {
                    seats += ticket[0];
                    seats += (int)ticket[1];

                }
                Console.WriteLine($"Seat decoded: {seats}");
            }
        }
    }
}
