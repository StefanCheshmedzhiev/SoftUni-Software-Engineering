using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int numberDays = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (town == "Bansko" || town == "Borovets")
            {
                if (package == "withEquipment")
                {
                    price = 100;
                    if (vipDiscount == "yes")
                    {
                        price *= 0.90;
                    }
                }
                else if (package == "noEquipment")
                {
                    price = 80;
                    if (vipDiscount == "yes")
                    {
                        price *= 0.95;
                    }
                }
            }
            if (town == "Varna" || town == "Burgas")
            {
                if (package == "withBreakfast")
                {
                    price = 130;
                    if (vipDiscount == "yes")
                    {
                        price *= 0.88;
                    }
                }
                else if (package == "noBreakfast")
                {
                    price = 100;
                    if (vipDiscount == "yes")
                    {
                        price *= 0.93;
                    }
                }
            }
            else if (town != "Bansko" || town != "Borovets" || town != "Varna" || town != "Burgas" || package != "withEquipment" || package != "noEquipment" || package != "withBreakfast" || package != "noBreakfast")
            {
                Console.WriteLine("Invalid input!");

            }
            double total = numberDays * price;
            if (numberDays > 7)
            {
                total = total - (total / numberDays);
            }
            if (numberDays == 0)
            {
                Console.WriteLine("Days must be positive number!");
            }           
            else
            {
                Console.WriteLine($"The price is {total:f2}lv! Have a nice time!");
            }

        }
    }
}
