using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int price = 0;
            bool isFull = false;
            while (input != "Movie time!")
            {
                int people = int.Parse(input);
                capacity -= people;
                if (capacity < 0)
                {
                    Console.WriteLine("The cinema is full.");
                    isFull = true;
                    break;
                }
                price += people * 5;
                if (people % 3 == 0)
                {
                    price -= 5;
                }
                
                input = Console.ReadLine();
            }
            if (!(isFull))
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {price} lv.");
        }
    }
}
