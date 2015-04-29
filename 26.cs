public class Solution {
    public int RemoveDuplicates(int[] A) {
        int length=0;
        Dictionary<int ,int> dict=new Dictionary<int ,int>();
        foreach(int x in A){
            if(dict.ContainsKey(x)){
                dict[x]++;
            }else{
                dict.Add(x,1);
            }
        }
        var tmp=dict.Select(x=>x.Key).OrderBy(z=>z).ToArray();
        for(int i=0;i<dict.Keys.Count;i++)
            A[i]=tmp[i];
        return tmp.Count();
    }
}