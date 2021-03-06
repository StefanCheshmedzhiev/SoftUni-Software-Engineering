using System;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountVoucher = int.Parse(Console.ReadLine());
            string article = Console.ReadLine();
            int counterMovies = 0;
            int otherArticles = 0;
            int sumPrice = 0;
            
            while (article != "End")
            {

                if (article.Length > 8)
                {
                    sumPrice = (article[0] + article[1]);
                    if (amountVoucher - sumPrice < 0)
                    {
                        break;
                    }
                    else
                    {
                        counterMovies++;
                        amountVoucher -= sumPrice;
                    }
                    
                }
                else if (article.Length <= 8)
                {
                    sumPrice = article[0];
                    if (amountVoucher - sumPrice < 0)
                    {
                        break;
                    }
                    else
                    {
                        otherArticles++;
                        amountVoucher -= sumPrice;
                    }
                    
                }
               
                article = Console.ReadLine();
            }
            Console.WriteLine($"{counterMovies}");
            Console.WriteLine($"{otherArticles}");
        }
    }
}
