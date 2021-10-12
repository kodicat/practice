namespace Arrays.Arrays
{
	public class BestTimeToBuyAndSellStockII
	{
		public int MaxProfit(int[] prices)
		{
			if (prices.Length < 2)
				return 0;

			int maxProfit = 0;
			int peakStart = 0;
			for (int peakEnd = 0; peakEnd < prices.Length; peakEnd++)
			{
				if (IsPeakEnd(prices, peakEnd))
				{
					if(peakEnd != peakStart)
						maxProfit += prices[peakEnd] - prices[peakStart];
					peakStart = peakEnd + 1;
				}
			}

			return maxProfit;
		}

		static bool IsPeakEnd(int[] prices, int index)
		{
			if (index == prices.Length - 1)
				return true;

			return prices[index] > prices[index + 1];
		}
	}
}
