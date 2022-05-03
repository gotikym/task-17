using System;
internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        byte minimumCostForBook = 1;
        byte maximumCostForBook = 28;
        int maximumGoldForTrade = 1000;
        int minimumGoldForTrade = 100;
        int countBookForTrade = 0;
        int randomCostBook = random.Next(minimumCostForBook, maximumCostForBook);

        for (int i = 0; i <= maximumGoldForTrade; i += randomCostBook)
        {
            if (i >= minimumGoldForTrade)
            {
                countBookForTrade++;
            }
        }
        Console.WriteLine(countBookForTrade);
    }
}