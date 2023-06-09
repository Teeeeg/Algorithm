namespace AlgorithmAD.Basic;

public class IsomorphicStrings205
{
    public bool IsIsomorphic(string s, string t)
    {
        var mapper = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            var char1 = s[i];
            var char2 = t[i];

            if (mapper.ContainsKey(char1))
            {
                if (mapper[char1] != char2)
                {
                    return false;
                }
            }
            else
            {
                if (mapper.ContainsValue(char2))
                {
                    return false;
                }
                mapper.Add(char1, char2);
            }
        }

        return true;
    }

    public void Test()
    {
        string s = "badc";
        string t = "baba";

        System.Console.WriteLine(IsIsomorphic(s, t));
    }
}
