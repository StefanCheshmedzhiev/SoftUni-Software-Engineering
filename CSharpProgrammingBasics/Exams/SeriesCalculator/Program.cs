using System;

namespace SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSeries = Console.ReadLine();
            int numberSeasons = int.Parse(Console.ReadLine());
            int numberSeries = int.Parse(Console.ReadLine());
            double durationWithoutAdds = double.Parse(Console.ReadLine());

            double durationAddsForOneSeries = durationWithoutAdds * 0.20;
            double durationSeriesPlusAdds = durationWithoutAdds + durationAddsForOneSeries;
            double additionalTime = numberSeasons * 10;
            double totalTime = durationSeriesPlusAdds * numberSeasons * numberSeries + additionalTime;
            Console.WriteLine($"Total time needed to watch the {nameSeries} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
