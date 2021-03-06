using System;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultFirstMatch = Console.ReadLine();
            string resultSecondMatch = Console.ReadLine();
            string resultThirdMatch = Console.ReadLine();

            int counterWins = 0;
            int counterLosts = 0;
            int counterDraws = 0;

            int firstNumber1 = resultFirstMatch[0];
            int lastNUmber2 = resultFirstMatch[2];
            int firstNumber3 = resultSecondMatch[0];
            int lastNUmber4 = resultSecondMatch[2];
            int firstNumber5 = resultThirdMatch[0];
            int lastNUmber6 = resultThirdMatch[2];

            if (firstNumber1 > lastNUmber2)
            {
                counterWins++;
            }
            else if (firstNumber1 < lastNUmber2)
            {
                counterLosts++;
            }
            else
            {
                counterDraws++;
            }
            if (firstNumber3 > lastNUmber4)
            {
                counterWins++;
            }
            else if (firstNumber3 < lastNUmber4)
            {
                counterLosts++;
            }
            else
            {
                counterDraws++;
            }
            if (firstNumber5 > lastNUmber6)
            {
                counterWins++;
            }
            else if (firstNumber5 < lastNUmber6)
            {
                counterLosts++;
            }
            else
            {
                counterDraws++;
            }

            Console.WriteLine($"Team won {counterWins} games.");
            Console.WriteLine($"Team lost {counterLosts} games.");
            Console.WriteLine($"Drawn games: {counterDraws}");
        }
    }
}
