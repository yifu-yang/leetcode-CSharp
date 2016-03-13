public class Solution
{
    public string LongestPalindrome(string s)
    {
        string res = string.Empty;
        string tmp = string.Empty;
        int maxLength = s.Length;

        if (maxLength <= 1)
            return s;
        for (int i = 0; i < s.Length; i++)
        {
            string s1 = GetMaxSubString(s, i, true);
            string s2 = GetMaxSubString(s, i, false);
            if (s1.Length > s2.Length)
            {
                if (s1.Length > res.Length)
                    res = s1;
            }
            else {
                if (s2.Length > res.Length)
                    res = s2;

            }
        }
        return res;
    }

    string GetMaxSubString(string s, int index, bool isCenter)
    {
        if (isCenter)
        {
            int smap = 1;
            while (index - smap >= 0 && index + smap < s.Length)
            {
                if (s[index - smap].Equals(s[index + smap]))
                    smap++;
                else {
                    return s.Substring(index - smap + 1, (smap - 1) * 2 + 1);
                }
            }
            return s.Substring(index - smap + 1, (smap - 1) * 2 + 1);
        }
        else {
            int smap = 1;
            int left = index, right = index + smap;
            while (left >= 0 && right < s.Length)
            {
                if (s[left].Equals(s[right]))
                {
                    left -= smap;
                    right += smap;
                }
                else
                    return s.Substring(left + smap, right - left - smap);
            }
            return s.Substring(left + smap, right - left - smap);
        }
    }


}