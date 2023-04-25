namespace Algorithm;

class TwoSum1
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        var res = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var numToFill = target - nums[i];
            if (map.ContainsKey(numToFill))
            {
                res.Add(map[numToFill]);
                res.Add(i);
                break;
            }
            map[nums[i]] = i;
        }

        return res.ToArray();
    }

    public void Test()
    {
        int[] nums = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
        int target = 11;

        var res = TwoSum(nums, target);
        res.Print();
    }
}