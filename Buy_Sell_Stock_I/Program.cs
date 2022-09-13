// See https://aka.ms/new-console-template for more information

int[] stockPrice = {7,1,5,3,6,4};
Console.WriteLine(MaxProfit(stockPrice));

int MaxProfit(int[] prices)
{
    int profit = 0;
    int buyPrice = prices[0];

    for (int i = 0; i < prices.Length - 1; i++)
    {
        int tempProfit = prices[i + 1] - prices[i];
        if (tempProfit > 0)
        {
            if (prices[i] < buyPrice)
            {
                buyPrice = prices[i];
            }

            if (prices[i + 1] - buyPrice > profit)
            {
                profit = prices[i + 1] - buyPrice;
            }
        }
    }

    return profit;
}