using System;
using System.Collections.Generic;

namespace Coding_ABinaryTree02
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
    class BinaryTree
    {
        static void Main02()
        {
            TreeNode node = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            PreorderTraversal(node);
            InorderTraversal(node);
            PostorderTraversal(node);

        }
        public static List<int> PreorderTraversal(TreeNode root)
        {
            List<int> answer = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            if (root != null)
            {
                s.Push(root);
            }
            TreeNode cur;
            while (s.Count > 0)
            {
                cur = s.Pop();
                answer.Add(cur.val);            // visit the root
                if (cur.right != null)
                {
                    s.Push(cur.right);          // push right child to stack if it is not null
                }
                if (cur.left != null)
                {
                    s.Push(cur.left);           // push left child to stack if it is not null
                }
            }
            return answer;
        }
        private static List<int> InorderTraversal(TreeNode root)
        {
            List<int> answer = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            if (root != null)
            {
                s.Push(root);
            }
            TreeNode cur;
            while (s.Count > 0)
            {
                cur = s.Pop();
                if (cur.right != null)
                {
                    s.Push(cur.right);          // push right child to stack if it is not null
                }
                // visit the root
                if (cur.left == null && cur.right == null)
                    answer.Add(cur.val);            
                else
                {
                    TreeNode curRoot = new TreeNode(cur.val);
                    s.Push(curRoot);
                }
                if (cur.left != null)
                {
                    s.Push(cur.left);           // push left child to stack if it is not null
                }
            }
            return answer;
        }
        private static List<int> PostorderTraversal(TreeNode root)
        {
            List<int> answer = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            if (root != null)
            {
                s.Push(root);
            }
            TreeNode cur;
            while (s.Count > 0)
            {
                cur = s.Pop();
                // visit the root
                if (cur.left == null && cur.right == null)
                    answer.Add(cur.val);
                else
                {
                    TreeNode curRoot = new TreeNode(cur.val);
                    s.Push(curRoot);
                }
                if (cur.right != null)
                {
                    s.Push(cur.right);          // push right child to stack if it is not null
                }
                if (cur.left != null)
                {
                    s.Push(cur.left);           // push left child to stack if it is not null
                }
            }
            return answer;
        }
    }
}