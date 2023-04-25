using System.Diagnostics;

namespace AlgorithmAD.Basic;

public class IsSubsequence392
{
    public bool IsSubsequence(string s, string t)
    {
        if (s == string.Empty)
        {
            return true;
        }

        var index = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (index < s.Length && s[index] == t[i])
            {
                index++;
            }
        }

        return index == s.Length;
    }

    public void Test()
    {
        var s = "b";
        var t = "c";

        System.Console.WriteLine(IsSubsequence(s, t));
    }
}
