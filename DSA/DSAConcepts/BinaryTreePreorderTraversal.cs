using System;
using System.Collections.Generic;

namespace DSAConcepts_BinaryTreePreorderTraversal
{
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
    class BinaryTreePreorderTraversal
    {
        static void Main01()
        {
            TreeNode tree1 = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            PreorderTraversalIterative(tree1); //1,2,3
            PreorderTraversalRecursive(tree1);
        }
        public static List<int> PreorderTraversalIterative(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Count>0)
            {
                TreeNode current = stack.Pop();
                result.Add(current.val);
                if (current.right != null) stack.Push(current.right);
                if (current.left != null) stack.Push(current.left);
            }
            return result;
        }
        public static List<int> PreorderTraversalRecursive(TreeNode root)
        {
            List<int> result = new List<int>();
            PreorderTraversalRecursive(root, result);
            return result;
        }
        public static void PreorderTraversalRecursive(TreeNode root, List<int> result)
        {
            if (root != null)
            {
                result.Add(root.val);
                PreorderTraversalRecursive(root.left, result);
                PreorderTraversalRecursive(root.right, result);
            }
        }
    }
}
