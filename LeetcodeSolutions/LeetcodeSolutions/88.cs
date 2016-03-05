public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        List<int> list =new List<int>();
        int i=0,j=0;
        
        while(i<m&&j<n){
            if(nums1[i]<=nums2[j]){
                list.Add(nums1[i]);
                i++;
            }
            else{
                list.Add(nums2[j]);
                j++;
            }
        }
        if(i==m){
            for(;j<n;j++){
                list.Add(nums2[j]);
            }
        }
        if(j==n){
            for(;i<m;i++){
                list.Add(nums1[i]);
            }
        }
        for(i =0 ; i<list.Count;i++){
            nums1[i]=list[i];
        }
    }
}