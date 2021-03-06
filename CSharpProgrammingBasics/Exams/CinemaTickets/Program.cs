using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int studentTicketCount = 0;
            int standardTicketCount = 0;
            int kidTicketCount = 0;
            
            int totalTicketCount = 0;

            while (name != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int ticketCount = 0;
                for (int i = 1; i <= freePlaces; i++)
                {
                    string type = Console.ReadLine();
                    switch (type)
                    {
                        case "student":
                            studentTicketCount++;
                            ticketCount++;
                            break;
                        case "standard":
                            standardTicketCount++;
                            ticketCount++;
                            break;
                        case "kid":
                            kidTicketCount++;
                            ticketCount++;
                            break;


                    }
                    if (type == "End")
                    {
                        break;
                    }
                }
                totalTicketCount += ticketCount;
                Console.WriteLine($"{name} - {(ticketCount * 1.0 / freePlaces) * 100:f2}% full.");
               name = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTicketCount}");
            Console.WriteLine($"{(studentTicketCount * 1.0 / totalTicketCount) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTicketCount * 1.0 / totalTicketCount) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidTicketCount * 1.0 / totalTicketCount) * 100:f2}% kids tickets.");
        }
    }
}
