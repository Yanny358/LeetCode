// See https://aka.ms/new-console-template for more information

int[] stockPrices = { 7, 1, 5, 3, 6, 4 };

Console.WriteLine(MaxProfit(stockPrices));

int MaxProfit(int[] prices) {
    int maxProfit = 0;

    for (int i = 0; i < prices.Length - 1; i++)
    {
        if (prices[i] < prices[i + 1])
        {
            maxProfit += prices[i + 1] - prices[i];
        }
    }

    return maxProfit;

}
