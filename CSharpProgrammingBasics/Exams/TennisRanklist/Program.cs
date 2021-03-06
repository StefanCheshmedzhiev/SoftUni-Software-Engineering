using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTournaments = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            int points = 0;
            int counterWins = 0;
            for (int i = 0; i < numberTournaments; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                   case "W":
                        points += 2000;
                        initialPoints += 2000;
                        counterWins++;
                        break;
                   case "F":
                        points += 1200;
                        initialPoints += 1200;
                        break;
                    case "SF":
                        points += 720;
                        initialPoints += 720;
                        break;
                }
            }
            double average = Math.Floor(points * 1.0 / numberTournaments);
            double percent = (counterWins * 1.0 / numberTournaments) * 100;

            Console.WriteLine($"Final points: {initialPoints}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
