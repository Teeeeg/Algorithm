namespace AlgorithmAD.Top150;

public class MajorityElement169
{
    public int MajorityElement(int[] nums)
    {
        var result = 0;
        var count = 0;

        foreach (var num in nums)
        {
            if (count == 0)
            {
                result = num;
                count = 1;
            }
            else if (result == num)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return result;
    }
}
