public class Solution {
    public int LengthOfLastWord(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return 0;
            }
            var strings = s.Split(' ');
            for(int i= strings.Length-1 ;i >=0 ;i--){
                if(!String.IsNullOrEmpty(strings[i])){
                    return strings[i].Length;
                }
            }
            return strings[strings.Length - 1].Length;
        }
}