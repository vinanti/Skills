using System;

namespace Coding_ABST02
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
    class ABST02_SearchIterative
    {
        static void Main02()
        {
            TreeNode root = new TreeNode(5, new TreeNode(2, new TreeNode(1), new TreeNode(4, new TreeNode(3))), new TreeNode(6, null, new TreeNode(7)));
            SearchBST(root, 4);
        }
        public static TreeNode SearchBST(TreeNode root, int target)
        {
            TreeNode cur = root;
            while (cur != null && cur.val != target)
            {
                if (target < cur.val)
                {
                    cur = cur.left;
                }
                else
                {
                    cur = cur.right;
                }
            }
            return cur;
        }
    }
}
