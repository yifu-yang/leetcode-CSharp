public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dict =new Dictionary<char,int>();
        foreach(char c in s){
            if(dict.ContainsKey(c)){
                continue;
            }
            else{
                dict.Add(c,-1);
            }
        }
        int l=0,t=0;
        for(int i=0;i<s.Length&&t<s.Length;){
            if(dict[s[t]]==-1){
                dict[s[t]]=t;
                t++;
            }
            else{
                if(i<=dict[s[t]]){
                i=dict[s[t]]+1;
                dict[s[t]]=t++;}
                else{
                    dict[s[t]]=t;
                    t++;
                }
            }
            l=l>t-i?l:t-i;
        }
        return l;
    }
}?