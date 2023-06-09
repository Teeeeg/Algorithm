namespace AlgorithmAD.Top150;

public class RemoveDuplicatesfromSortedArray26
{
    public int RemoveDuplicates(int[] nums)
    {
        var index = -1;

        foreach (var num in nums)
        {
            if (index != -1 && num == nums[index])
                continue;

            index += 1;
            nums[index] = num;
        }

        return index + 1;
    }


    public void Test()
    {
        var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var res = RemoveDuplicates(nums);
        Console.WriteLine(res);
    }
}
