//TODO
using System;

namespace Coding_ABinaryTree04
{
    class ABinaryTree04_MaxDepthTopDown
    {
        static void Main04()
        {
            TreeNode root = new TreeNode('E', new TreeNode('B', new TreeNode('A'), new TreeNode('D')), new TreeNode('F', null, new TreeNode('F')));
            Maximum_depth(root,1);
        }
        private static int answer; // don't forget to initialize answer before call maximum_depth
        private static void Maximum_depth(TreeNode root, int depth)
        {
            if (root == null)
            {
                return;
            }
            if (root.left == null && root.right == null)
            {
                answer = Math.Max(answer, depth);
            }
            Maximum_depth(root.left, depth + 1);
            Maximum_depth(root.right, depth + 1);
        }
    }
    public class TreeNode
    {
        public char val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(char val, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
