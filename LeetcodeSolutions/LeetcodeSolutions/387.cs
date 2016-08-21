public class Solution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<string, int> charCount = new Dictionary<string, int>();
        HashSet<string> notUniq = new HashSet<string>();
        for (int i = 0; i < s.Length; i++)
        {
            if (notUniq.Contains(s[i].ToString()))
                continue;
            if (!charCount.ContainsKey(s[i].ToString()))
            {
                charCount.Add(s[i].ToString(), i);
            }
            else
            {
                charCount.Remove(s[i].ToString());
                notUniq.Add(s[i].ToString());
            }
        }
        if (charCount.Count != 0)
            return charCount.OrderBy(x => x.Value).First().Value;
        else
            return -1;
    }
}