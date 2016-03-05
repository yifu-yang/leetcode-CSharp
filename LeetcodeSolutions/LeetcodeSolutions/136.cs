public class Solution {
    public int SingleNumber(int[] A) {
        var dict =new  Dictionary<int ,int>();
        for(int i=0;i<A.Count();i++)
        {
            if(dict.ContainsKey(A[i]))
            {
                dict[A[i]]+=1;
            }
            else
            {
                dict.Add(A[i],1);
            }
        }
        foreach(var t in dict)
        {
            if(t.Value==1){
                return t.Key;
            }
            
        }
        return 0;
    }
}