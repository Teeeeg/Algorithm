namespace AlgorithmAD.Basic;

public class BestTimetoBuyandSellStock121
{
    public int MaxProfit(int[] prices)
    {
        var dp = new int[2, prices.Length];
        dp[1, 0] = -prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            dp[0, i] = Math.Max(dp[0, i - 1], dp[1, i - 1] + prices[i]);
            dp[1, i] = Math.Max(dp[1, i - 1], -prices[i]);
        }

        return dp[0, prices.Length - 1];
    }
}
