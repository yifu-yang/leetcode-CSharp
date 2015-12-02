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
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
        if(root.left!=null||root.right!=null){
            int leftdepth=0;
            int rightdepth=0;
            leftdepth =MinDepth(root.left)+1;
            rightdepth=MinDepth(root.right)+1;
            if(root.left!=null&&root.right==null){
                return leftdepth;
            }
            
            if(root.right!=null&&root.left==null){
                return rightdepth;
            }
            return Math.Min(leftdepth,rightdepth);
        }
            
        else
            return  1;
    }
}