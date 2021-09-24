using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding_Q1026
{
    class Q1026
    {
        static void Main()
        {
            //TreeNode root = new TreeNode(8, new TreeNode(3, new TreeNode(1), new TreeNode(6, new TreeNode(4), new TreeNode(7))), new TreeNode(10, null, new TreeNode(14, new TreeNode(13))));
            TreeNode root = new TreeNode(1, null, new TreeNode(2, null, new TreeNode(0, new TreeNode(3))));
            MaxAncestorDiff(root);
        }
        public static int MaxAncestorDiff(TreeNode root)
        {
            if (root == null) return 0;
            int max = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode current = stack.Pop();
                if (current.left != null || current.right != null)
                {
                    max = Math.Max(max, current.val - GetMinChildVal(current));
                    if (current.left != null)
                        stack.Push(current.left);
                    if (current.right != null)
                        stack.Push(current.right);
                }
            }
            return max;
        }
        public static int GetMinChildVal(TreeNode root)
        {
            List<int> childs = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Count > 0)
            {
                TreeNode current = stack.Pop();
                childs.Add(current.val);
                if (current.left != null)
                    stack.Push(current.left);
                if (current.right != null)
                    stack.Push(current.right);
            }
            if (childs.Count > 0) return childs.Min();
            else return 0;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
