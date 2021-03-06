using System;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfReservation = int.Parse(Console.ReadLine());
            int monthOfReservation = int.Parse(Console.ReadLine());
            int dayOfAccomodation = int.Parse(Console.ReadLine());
            int monthOfAccomodation = int.Parse(Console.ReadLine());
            int dayOfLeaving = int.Parse(Console.ReadLine());
            int monthOfLeaving = int.Parse(Console.ReadLine());
            int numberNights = dayOfLeaving - dayOfAccomodation;
            double price = 0;

            if (dayOfReservation < dayOfAccomodation - 10)
            {
                price = 25.0;
            }
            else if (monthOfReservation <= monthOfAccomodation - 1)
            {
                price = 25 * 0.80;
            }
            else
            {
                price = 30.0;
            }
            
            double totalPrice = numberNights * price;
            Console.WriteLine($"Your stay from {dayOfAccomodation}/{monthOfAccomodation} to {dayOfLeaving}/{monthOfLeaving} will cost {totalPrice:f2}");
        }
    }
}
