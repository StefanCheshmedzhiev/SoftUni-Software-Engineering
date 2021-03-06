using System;

namespace FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string bestMovie = "";
            int maxValue = int.MinValue;
            int counter = 0;
            while (name != "STOP")
            {
                int sum = 0;
                counter++;
                for (int i = 0; i < name.Length; i++)
                {
                    int currentLetter = name[i];
                    
                    if (currentLetter >= 97 && currentLetter <= 122)
                    {
                        currentLetter -= 2 * name.Length;

                    }
                    else if (currentLetter >= 65 && currentLetter <= 90)
                    {
                        currentLetter -= name.Length;
                    }
                    sum += currentLetter;
                    if (sum > maxValue)
                    {
                        maxValue = sum;
                        bestMovie = name;
                    }
                }
                if (counter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
              name = Console.ReadLine();
            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {maxValue} ASCII sum.");
        }
    }
}
