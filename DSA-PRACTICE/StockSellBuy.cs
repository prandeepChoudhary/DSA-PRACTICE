using System;
namespace DSA_PRACTICE
{
	public class StockSellBuy
	{
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;  // Start with a very high number
            int maxProfit = 0;  // Start with no profit


            foreach (int price in prices)
            {
                if(price < minPrice)
                {
                    minPrice = price;
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, price - minPrice);
                }
            }
                return maxProfit;
        }

    }
}

