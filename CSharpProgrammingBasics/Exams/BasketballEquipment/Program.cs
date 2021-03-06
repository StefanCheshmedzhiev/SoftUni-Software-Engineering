using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());

            double priceBasketballSnickers = annualTax * 0.60;
            double priceEquipment = priceBasketballSnickers * 0.80;
            double priceBall = (priceEquipment * 1) / 4;
            double priceAccessories = (priceBall * 1) / 5;

            double total = annualTax + priceBasketballSnickers + priceEquipment + priceBall + priceAccessories;

            Console.WriteLine($"{total:f2}");
        }
    }
}
