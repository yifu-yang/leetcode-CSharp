public class Solution {
    public int[] GetNext(string s) 
        {
            int[] next = new int[s.Length];
            next[0] = -1;
            int j = 0;
            int k = -1;
            while (j != s.Length - 1) 
            {
                if (k == -1 || s[j] == s[k])
                {
                    next[++j] = ++k;
                }
                else 
                {
                    k = next[k];
                }
            }
            return next;
        }




        public int StrStr(string haystack, string needle) 
        {
            int i = 0, j = 0;
            if(haystack==""&&needle=="")
                return 0;
            if(haystack!=""&&needle=="")
                return 0;
            int[] next=GetNext(needle);
            


            while (i < haystack.Length && j < needle.Length)
            {
                if (j==-1||haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = next[j];
                }
            }


            if(j==needle.Length)
            {
                return i-j;
            }
            else
                return -1;
        }
}