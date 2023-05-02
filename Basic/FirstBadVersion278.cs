namespace AlgorithmAD.Basic;

public class FirstBadVersion278
{
    bool IsBadVersion(int version) { return false; }
    public int FirstBadVersion(int n)
    {
        var left = 1;
        var right = n;

        while (left + 1 < right)
        {
            var mid = (left + right) >> 1;

            if (IsBadVersion(mid) is false)
            {
                left = mid;
            }
            else
            {
                right = mid;
            }
        }

        if (IsBadVersion(left) is true)
        {
            return left;
        }

        return right;
    }
}
