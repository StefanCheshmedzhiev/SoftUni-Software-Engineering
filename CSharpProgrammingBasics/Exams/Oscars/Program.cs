using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int numberEvaluatingPeople = int.Parse(Console.ReadLine());
            bool isNomineeSuccessful = false;
            for (int i = 0; i < numberEvaluatingPeople; i++)
            {
                string evaluatingPerson = Console.ReadLine();
                double pointFromEvaluatingPerson = double.Parse(Console.ReadLine());

                pointsAcademy += (evaluatingPerson.Length * pointFromEvaluatingPerson) / 2;
                if (pointsAcademy > 1250.5)
                {
                    isNomineeSuccessful = true;
                    break;
                }
            }
            if (isNomineeSuccessful)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {pointsAcademy:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - pointsAcademy:f1} more!");
            }
        }
    }
}
