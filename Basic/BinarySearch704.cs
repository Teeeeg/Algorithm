namespace AlgorithmAD.Basic;

public class BinarySearch704
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length;

        while (left <= right)
        {
            var mid = (left + right) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}