using System;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirstPLayer = Console.ReadLine();
            string nameSecondPLayer = Console.ReadLine();
            int points1 = 0;
            int points2 = 0;
            string cardFirstPLayer = Console.ReadLine();

            while (cardFirstPLayer != "End of game")
            {
                string cardSecondPLayer = Console.ReadLine();
                int cardFirst = int.Parse(cardFirstPLayer);
                int cardSecond = int.Parse(cardSecondPLayer);
                if (cardFirst > cardSecond)
                {
                    points1 += (cardFirst - cardSecond);
                }
                else if (cardSecond > cardFirst)
                {
                    points2 += (cardSecond - cardFirst);
                }
                else if (cardFirst == cardSecond)
                {
                    Console.WriteLine("Number wars!");
                    string addFirst = Console.ReadLine();
                    string addSecond = Console.ReadLine();
                    if (int.Parse(addFirst) > int.Parse(addSecond))
                    {
                        Console.WriteLine($"{nameFirstPLayer} is winner with {points1} points");
                        break;
                    }
                    else if (int.Parse(addFirst) < int.Parse(addSecond))
                    {
                        Console.WriteLine($"{nameSecondPLayer} is winner with {points2} points");
                        break;
                    }
                }
                cardFirstPLayer = Console.ReadLine();
            }
            if (cardFirstPLayer == "End of game")
            {
                Console.WriteLine($"{nameFirstPLayer} has {points1} points");
                Console.WriteLine($"{nameSecondPLayer} has {points2} points");
            }
            
        }
    }
}
