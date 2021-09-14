/*Binary Tree Preorder Traversal*/
using System;
using System.Collections.Generic;
namespace Coding_0144
{
    class Q0144
    {
        static List<int> list = new List<int>();
        public static List<int> PreorderTraversal(TreeNode root)
        {
            if (root != null)
            {
                list.Add(root.val);
                PreorderTraversal(root.left);
                PreorderTraversal(root.right);
            }
            return list;
        }
        static void Main144()
        {
            TreeNode tree = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
            PreorderTraversal(tree);

            foreach (var item in list)
                Console.Write(item + "-");
        }
    }
    class TreeNode
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
}
