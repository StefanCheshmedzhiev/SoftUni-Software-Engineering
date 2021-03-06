using System;

namespace DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());
            string sector = Console.ReadLine();
            int counter = 1;
            while (sector != "bullseye")
            {
                int points = int.Parse(Console.ReadLine());
                if (sector == "number section")
                {
                    points *= 1;
                }
                else if (sector == "double ring")
                {
                    points *= 2;
                }
                else if (sector == "triple ring")
                {
                    points *= 3;
                }
                initialPoints -= points;
                if (initialPoints <= 0)
                {
                    break;
                }
                counter++;
                sector = Console.ReadLine();
            }
            if (initialPoints == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {counter} moves!");
            }
            else if (initialPoints < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(initialPoints)}.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
            }
        }
    }
}
