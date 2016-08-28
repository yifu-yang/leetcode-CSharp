public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        var source = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (source.ContainsKey(c))
            {
                source[c]++;
            }
            else
            {
                source.Add(c, 1);
            }
        }
        foreach (char c in s)
        {
            source[c]--;

        }
        return source.Where(x => x.Value > 0).Select(x => x.Key).First();
    }
}