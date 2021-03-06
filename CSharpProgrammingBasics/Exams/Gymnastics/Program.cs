using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();

            double difficulty = 0;
            double performance = 0;

            if (country == "Russia")
            {
                switch (device)
                {
                    case "ribbon":
                        difficulty = 9.100;
                        performance = 9.400;
                        break;
                    case "hoop":
                        difficulty = 9.300;
                        performance = 9.800;
                        break;
                    case "rope":
                        difficulty = 9.600;
                        performance = 9.000;
                        break;
                }
            }
            else if (country == "Bulgaria")
            {
                switch (device)
                {
                    case "ribbon":
                        difficulty = 9.600;
                        performance = 9.400;
                        break;
                    case "hoop":
                        difficulty = 9.550;
                        performance = 9.750;
                        break;
                    case "rope":
                        difficulty = 9.500;
                        performance = 9.400;
                        break;
                }
            }
            else if (country == "Italy")
            {
                switch (device)
                {
                    case "ribbon":
                        difficulty = 9.200;
                        performance = 9.500;
                        break;
                    case "hoop":
                        difficulty = 9.450;
                        performance = 9.350;
                        break;
                    case "rope":
                        difficulty = 9.700;
                        performance = 9.150;
                        break;
                }
            }
            double total = difficulty + performance;
            double rest = 20 - total;
            double percent = (rest / 20) * 100;

            Console.WriteLine($"The team of {country} get {total:f3} on {device}.");
            Console.WriteLine($"{percent:f2}%");

        }
    }
}
