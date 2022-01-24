using System;

namespace Buy_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = {1,2,3,4,5};
            MaxProfit(prices);
        }
        
       
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    profit += prices[i + 1] - prices[i];
                }
            }

            return profit;
        }
        
    }
}