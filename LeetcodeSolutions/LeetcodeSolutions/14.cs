public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return string.Empty;

        var list = new List<string>(strs);
        list = list.OrderBy(x => x.Length).ToList();

        string res = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (!list[i].StartsWith(res))
            {
                res = GetCommonPrefix(res, list[i]);
            }
        }
        return res;
    }

    string GetCommonPrefix(string s1, string s2)
    {
        string res = string.Empty;
        for (int i = 0; i < Math.Min(s1.Length, s2.Length); i++)
        {
            if (s1[i].Equals(s2[i]))
                res += s1[i];
            else { break; }
        }
        return res;
    }
}