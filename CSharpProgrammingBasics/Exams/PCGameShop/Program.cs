using System;

namespace PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            for (int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();
                if (game == "Hearthstone")
                {
                    p1++;
                }
                else if (game == "Fornite")
                {
                    p2++;
                }
                else if (game == "Overwatch")
                {
                    p3++;
                }
                else
                {
                    p4++;
                }
            }
            Console.WriteLine($"Hearthstone - {p1 * 1.0 / n * 100:f2}%");
            Console.WriteLine($"Fornite - {p2 * 1.0 / n * 100:f2}%");
            Console.WriteLine($"Overwatch - {p3 * 1.0 / n * 100:f2}%");
            Console.WriteLine($"Others - {p4 * 1.0 / n * 100:f2}%");
        }
    }
}
