/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root==null)
        return true;
        var left = GetSequence(root.left,true);
        var right = GetSequence(root.right,false);
        if(left.Count==right.Count)
        {
            for(int index=0;index<right.Count;index++)
            {
                if(left[index]!=right[index])
                {
                    return false;        
                }
            }
            return true;
        }
        
        return false;
        
    }
    
    public List<int> GetSequence(TreeNode root,bool IsLeft){
        List<int> s=new List<int>();
        if(root==null)
        {
            s.Add(-1);
            return s;
        }
        if(root.left==null&&root.right==null)
        {
            s.Add(root.val);
            return s;
        }
        if(IsLeft)
        {
            s.AddRange(GetSequence(root.left,IsLeft));
            s.Add(root.val);
            s.AddRange(GetSequence(root.right,!IsLeft));
        }
        else
        {
            s.AddRange(GetSequence(root.right,IsLeft));
            s.Add(root.val);
            s.AddRange(GetSequence(root.left,!IsLeft));           
        }
        return s;
    }
}