using System;

namespace MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            bool isNotEnough = false;
            while (input != "ACTION")
            {

                if (input.Length <= 15)
                {
                    double remuneration = double.Parse(Console.ReadLine());
                    budget -= remuneration;
                }
                if (input.Length > 15)
                {
                    budget -= budget * 0.20;
                }
                if (budget < 0)
                {
                    isNotEnough = true;
                    break;
                }
               input = Console.ReadLine();
            }
            if (isNotEnough)
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
