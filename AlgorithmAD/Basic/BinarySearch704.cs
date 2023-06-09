namespace AlgorithmAD.Basic;

public class BinarySearch704
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left + 1 < right)
        {
            var mid = (left + right) / 2;

            if (nums[mid] <= target)
            {
                left = mid;
            }
            else
            {
                right = mid;
            }
        }

        if (nums[left] == target)
        {
            return left;
        }

        if (nums[right] == target)
        {
            return right;
        }

        return -1;
    }
}
