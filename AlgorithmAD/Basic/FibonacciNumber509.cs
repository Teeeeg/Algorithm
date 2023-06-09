namespace AlgorithmAD.Basic;

public class FibonacciNumber509
{
    public int Fib(int n)
    {
        if (n < 2)
        {
            return n;
        }
        var dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;


        for (int i = 2; i < n + 1; i++)
        {
            dp[i] = dp[i - 2] + dp[i - 1];
        }

        return dp[n];
    }

    public void Test()
    {
        var res = Fib(0);
        System.Console.WriteLine(res);
    }
}
