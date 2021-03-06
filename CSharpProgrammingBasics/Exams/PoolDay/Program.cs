using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            double entryTax = double.Parse(Console.ReadLine());
            double priceForOneChair = double.Parse(Console.ReadLine());
            double priceForOneUmbrella = double.Parse(Console.ReadLine());

            double incomeTaxes = numberPeople * entryTax;
            double numberChairs = Math.Ceiling(numberPeople * 0.75);
            double priceChairs = numberChairs * priceForOneChair;
            double numberUmbrellas = Math.Ceiling(numberPeople * 0.50);
            double priceUmbrellas = numberUmbrellas * priceForOneUmbrella;
            double totalPrice = incomeTaxes + priceChairs + priceUmbrellas;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
