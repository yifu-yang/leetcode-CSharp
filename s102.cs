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
    public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            IList<TreeNode> rootList = new List<TreeNode>();
            rootList.Add(root);
            while (rootList.Count > 0) 
            {
                IList<int> s = new List<int>();
                IList<TreeNode> tmp = new List<TreeNode>();
                foreach (var item in rootList)
                {
                    s.Add(item.val);
                    if (item.left != null)
                        tmp.Add(item.left);
                    if (item.right != null)
                        tmp.Add(item.right);
                }
                result.Add(s);
                rootList = tmp;
            }
            return result;
        }
}