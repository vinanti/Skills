using System;
using System.Collections.Generic;

namespace Coding_Q0145
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BinaryTree
    {
        List<int> list = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null) return list;
            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            list.Add(root.val);
            return list;
        }
    }
    class Q0145
    {
        static void Main145()
        {
            BinaryTree b = new BinaryTree();
            TreeNode node = new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null));
            b.PostorderTraversal(node);
        }
    }
}
