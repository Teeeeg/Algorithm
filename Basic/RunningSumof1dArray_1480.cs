namespace AlgorithmAD.Basic;

public class RunningSumof1dArray_1480
{
    public int[] RunningSum(int[] nums)
    {
        var res = new List<int>();
        var preSum = 0;

        foreach (var num in nums)
        {
            preSum += num;
            res.Add(preSum);
        }

        return res.ToArray();
    }
}
