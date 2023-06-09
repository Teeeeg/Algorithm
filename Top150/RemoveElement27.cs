using AlgorithmAD.Extension;

namespace AlgorithmAD.Top150;

public class RemoveElement27
{
    public int RemoveElement(int[] nums, int val)
    {
        int index = 0;

        foreach (var num in nums)
        {
            if (num != val)
            {
                nums[index] = num;
                index += 1;
            }
        }

        return index + 1;
    }
    public void Test()
    {
        var nums = new int[] { 1 };
        var val = 1;

        var res = RemoveElement(nums, val);
        Console.WriteLine(res);

        nums.Print();
    }

}
