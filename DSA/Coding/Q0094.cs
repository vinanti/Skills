/*Binary Tree Inorder Traversal*/
using System;
using System.Collections.Generic;

namespace Coding_Q0094
{
    public class BinaryTree
    {
        static List<int> list = new List<int>();
        public static List<int> InorderTraversal(TreeNode root)
        {
            if(root != null)
            {
                InorderTraversal(root.left);
                list.Add(root.val);
                InorderTraversal(root.right);
            }
            return list;
        }
        static void Main94()
        {
            TreeNode tree = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
            InorderTraversal(tree);

            foreach (var item in list)
                Console.Write(item + "-");
        }
    }
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
}
