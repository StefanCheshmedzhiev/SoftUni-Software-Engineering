using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredHeigth = int.Parse(Console.ReadLine());
            int startingHeigth = desiredHeigth - 30;
            bool isFailed = false;
            int jumps = 0;
            while (startingHeigth <= desiredHeigth)
            {
                
                
                for (int i = 0; i < 3; i++)
                {
                    jumps++;
                    int currentHeigth = int.Parse(Console.ReadLine());
                    if (currentHeigth > startingHeigth)
                    {
                        startingHeigth += 5;
                        break;
                    }
                    if (i == 2)
                    {
                        isFailed = true;
                        Console.WriteLine($"Tihomir failed at {startingHeigth}cm after {jumps} jumps.");
                        break;
                    }
                }
                if (isFailed)
                {
                    break;
                }
            }
            if (!(isFailed))
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeigth}cm after {jumps} jumps.");
            }
            
        }
    }
}
