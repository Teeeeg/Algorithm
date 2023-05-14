namespace AlgorithmAD.Basic;

public class ClimbingStairs70
{
    public int ClimbStairs(int n)
    {
        var dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;

        if (n < 2)
        {
            return dp[n];
        }

        for (int i = 2; i < n + 1; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }

    public void Test()
    {
        var res = ClimbStairs(1);
        Console.WriteLine(res);
    }
}