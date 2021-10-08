using System;
using System.Collections.Generic;

namespace Coding_Q0872
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

    public class Q0872
    {
        static void Main872()
        {
            TreeNode root1 = new TreeNode(1,
                new TreeNode(2), new TreeNode(3));
            TreeNode root2 = new TreeNode(1,
                new TreeNode(3), new TreeNode(2));
            bool result =  LeafSimilar(root1, root2);
        }
        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<TreeNode> list1 = GetLeafLeftToRight(root1);
            List<TreeNode> list2 = GetLeafLeftToRight(root2);
            foreach (TreeNode node in list1)
                if (!list2.Contains(node)) return false;
            return true;
        }
        public static List<TreeNode> GetLeafLeftToRight(TreeNode root)
        {
            List<TreeNode> list = new List<TreeNode>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode temp = stack.Pop();
                if (temp.right == null && temp.left == null) list.Add(temp);
                if (temp.right != null) stack.Push(temp.right);
                if (temp.left != null) stack.Push(temp.left);
            }
            return list;
        }
    }
}
