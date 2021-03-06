using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string clubName = Console.ReadLine();
            int numberGamesPlayed = int.Parse(Console.ReadLine());
            int points = 0;
            int counterWins = 0;
            int counterDraws = 0;
            int counterLosts = 0;
            
            for (int i = 0; i < numberGamesPlayed; i++)
            {
                char result = char.Parse(Console.ReadLine());
                if (result == 'W')
                {
                    points += 3;
                    counterWins++;
                }
                else if (result == 'D')
                {
                    points += 1;
                    counterDraws++;
                }
                else
                {
                    counterLosts++;
                }
                
                if (numberGamesPlayed == 0)
                {
                    break;
                }

            }
            if (numberGamesPlayed == 0)
            {
                Console.WriteLine($"{clubName} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{clubName} has won {points} points during this season");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {counterWins}");
                Console.WriteLine($"## D: {counterDraws}");
                Console.WriteLine($"## L: {counterLosts}");
                Console.WriteLine($"Win rate: {counterWins * 1.0 / numberGamesPlayed * 100:f2}%");
            }
        }
    }
}
