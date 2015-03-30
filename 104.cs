/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        
        if(root==null){
            return 0;
        }else{
            int left=0,right=0;
            if(root.left!=null)
            {
                left=MaxDepth(root.left);
            }
            if(root.right!=null){
                right=MaxDepth(root.right);
            }
            if(left>right)
                return left+1;
            else if(left<right)
                return right+1;
            else if(left==right)
                return left+1;

        }
    }
}