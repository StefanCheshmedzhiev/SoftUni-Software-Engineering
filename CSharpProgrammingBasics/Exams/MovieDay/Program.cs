using System;

namespace MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForPictures = int.Parse(Console.ReadLine());
            int numberScenes = int.Parse(Console.ReadLine());
            int durationOneScene = int.Parse(Console.ReadLine());

            double terrainPreparation = timeForPictures * 0.15;
            double timePicturingScenes = numberScenes * durationOneScene;
            double timeNeeded = terrainPreparation + timePicturingScenes;

            if (timeForPictures >= timeNeeded)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForPictures - timeNeeded)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {timeNeeded - timeForPictures} minutes.");
            }
        }
    }
}
