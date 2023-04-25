namespace AlgorithmAD.Basic;

public class FindPivotIndex724
{
    public int PivotIndex(int[] nums)
    {
        int total = nums.Sum();
        int preSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (2 * preSum == total - nums[i])
            {
                return i;
            }
            preSum += nums[i];
        }

        return -1;
    }
}
