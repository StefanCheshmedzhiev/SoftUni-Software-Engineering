using System;

namespace CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());

            double price = 0;

            if (cruiseType == "Mediterranean")
            {
                if (cabinType == "standard cabin")
                {
                    price = 27.50;
                }
                else if (cabinType == "cabin with balcony")
                {
                    price = 30.20;
                }
                else
                {
                    price = 40.50;
                }
            }
            if (cruiseType == "Adriatic")
            {
                if (cabinType == "standard cabin")
                {
                    price = 22.99;
                }
                else if (cabinType == "cabin with balcony")
                {
                    price = 25;
                }
                else
                {
                    price = 34.99;
                }
            }
            if (cruiseType == "Aegean")
            {
                if (cabinType == "standard cabin")
                {
                    price = 23;
                }
                else if (cabinType == "cabin with balcony")
                {
                    price = 26.60;
                }
                else
                {
                    price = 39.80;
                }
            }
            double totalPrice = numberNights * price * 4;
            if (numberNights > 7)
            {
                totalPrice *= 0.75;
            }
            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {totalPrice:f2} lv.");
        }
    }
}
