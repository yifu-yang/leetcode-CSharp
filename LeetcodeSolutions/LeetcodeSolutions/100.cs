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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p==null||q==null){
            if(p==q){
                return true;
            }
            else
                return false;
        }
        else{
            return (p.val==q.val)&&(IsSameTree(p.left,q.left))&&(IsSameTree(p.right,q.right));
        }
    }
}?