public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int tStep = 0, sStep = 0;

        if (s.Length > t.Length)
            return false;

        if (s.Equals(t))
            return true;

        for (tStep = 0; tStep < t.Length; tStep++)
        {

            if (s.Length > sStep && t[tStep].Equals(s[sStep]))
            {
                sStep++;
            }

            if (sStep == s.Length - 1 || s.Length == 0)
                return true;
        }
        return false;
    }
}