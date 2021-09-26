using System;

namespace Coding_ABST01
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x, TreeNode left = null, TreeNode right = null) 
        { 
            val = x;
            this.left = left;
            this.right = right;
        }
    }
    class ABST01_SearchRecursive
    {
        static void Main01()
        {
            TreeNode root = new TreeNode(5,new TreeNode(2, new TreeNode(1),new TreeNode(4, new TreeNode(3))),new TreeNode(6,null, new TreeNode(7)));
            SearchBST(root, 4);
        }
        public static TreeNode SearchBST(TreeNode root, int target)
        {
            if (root == null || root.val == target)
            {
                return root;
            }
            if (target < root.val)
            {
                return SearchBST(root.left, target);
            }
            return SearchBST(root.right, target);
        }
    }
}
