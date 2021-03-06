using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMovies = int.Parse(Console.ReadLine());
            double maxValue = double.MinValue;
            string bestMovie = "";
            double minValue = double.MaxValue;
            string worstMovie = "";
            double sum = 0;
            for (int i = 0; i < numberMovies; i++)
            {
                string name = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if (rating > maxValue)
                {
                    maxValue = rating;
                    bestMovie = name;
                }
                if (rating < minValue)
                {
                    minValue = rating;
                    worstMovie = name;
                }
                sum += rating;
            }
            double average = sum / numberMovies;
            Console.WriteLine($"{bestMovie} is with highest rating: {maxValue:f1}");
            Console.WriteLine($"{worstMovie} is with lowest rating: {minValue:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
