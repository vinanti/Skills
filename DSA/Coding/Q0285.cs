using System;
using System.Collections.Generic;

namespace Coding_Q0285
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Q0285
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            TreeNode result = null;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode temp = stack.Pop();
                if (result == null && temp.val > p.val)
                    result = temp;
                else if (result != null && result.val > temp.val && temp.val > p.val)
                    result.val = temp.val;
                if (temp.left != null) stack.Push(temp.left);
                if (temp.right != null) stack.Push(temp.right);
            }
            if (result == p) return null;
            else return result;
        }
    }
}
