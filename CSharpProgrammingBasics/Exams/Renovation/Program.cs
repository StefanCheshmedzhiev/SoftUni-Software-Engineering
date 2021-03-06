using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            int totalSurface = height * width * 4;
            double onlyWalls = Math.Ceiling(totalSurface - totalSurface * (percent * 1.0 / 100));

            string liters = Console.ReadLine();
            while (liters != "Tired!")
            {

                onlyWalls -= int.Parse(liters);
                if (onlyWalls <= 0)
                {
                    break;
                }
                liters = Console.ReadLine();

            }
            if (onlyWalls == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
            else if (onlyWalls < 0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(onlyWalls)} l paint left!");

            }
            else
            {
                Console.WriteLine($"{onlyWalls} quadratic m left.");
            }
        }
    }
}
