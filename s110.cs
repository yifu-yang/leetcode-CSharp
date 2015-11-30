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
    public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (IsBalanced(root.left) && IsBalanced(root.right)) 
            {
                if (Math.Abs(GetHeight(root.left)-GetHeight(root.right)) <= 1)
                    return true;
            }
            return false;
        }


        public int GetHeight(TreeNode root) 
        {
            int leftHeight = 0 ;
            int rightHeight = 0;
            if (root == null)
                return 0;
            if (root.left != null)
                leftHeight = GetHeight(root.left);
            if (root.right != null)
                rightHeight = GetHeight(root.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
}