using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int durationSeries = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());

            double timeLunch = (durationBreak * 1) / 8.0;
            double timeBreak = (durationBreak * 1) / 4.0;
            double timeRest = durationBreak - (timeLunch + timeBreak);
            if (timeRest >= durationSeries)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeRest - durationSeries)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(durationSeries - timeRest)} more minutes.");
            }


        }
    }
}
