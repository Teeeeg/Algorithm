namespace AlgorithmAD.Basic;

public class LongestPalindrome409
{
    public int LongestPalindrome(string s)
    {
        var dct = new Dictionary<char, int>();

        foreach (var ch in s)
        {
            if (!dct.ContainsKey(ch))
            {
                dct.Add(ch, 0);
            }
            dct[ch] += 1;
        }

        var isSeen = false;
        var res = 0;

        foreach (var val in dct.Values)
        {
            if (val % 2 == 0)
            {
                res += val;
            }
            else if (isSeen is false)
            {
                res += val;
                isSeen = true;
            }
            else
            {
                res += val - 1;
            }
        }

        return res;
    }
}
