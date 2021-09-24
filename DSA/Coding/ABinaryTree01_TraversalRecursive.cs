using System;
using System.Collections.Generic;

namespace Coding_ABinaryTree01
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
        static void Main01()
        {
            TreeNode node = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            PreorderTraversal(node);
            InorderTraversal(node);
            postorderTraversal(node);
            
        }
        private static void PreorderTraversal(TreeNode root, List<int> answer)
        {
            if (root == null)
            {
                return;
            }
            answer.Add(root.val);                   // visit the root
            PreorderTraversal(root.left, answer);   // traverse left subtree
            PreorderTraversal(root.right, answer);  // traverse right subtree
        }
        public static List<int> PreorderTraversal(TreeNode root)
        {
            List<int> answer = new List<int>();
            PreorderTraversal(root, answer);
            return answer;
        }

        private static void InorderTraversal(TreeNode root, List<int> answer)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversal(root.left, answer);   // traverse left subtree
            answer.Add(root.val);                  // visit the root
            InorderTraversal(root.right, answer);  // traverse right subtree
        }
        public static List<int> InorderTraversal(TreeNode root)
        {
            List<int> answer = new List<int>();
            InorderTraversal(root, answer);
            return answer;
        }
        private static void PostorderTraversal(TreeNode root, List<int> answer)
        {
            if (root == null)
            {
                return;
            }
            PostorderTraversal(root.left, answer);   // traverse left subtree
            PostorderTraversal(root.right, answer);  // traverse right subtree
            answer.Add(root.val);                    // visit the root
        }
        public static List<int> postorderTraversal(TreeNode root)
        {
            List<int> answer = new List<int>();
            PostorderTraversal(root, answer);
            return answer;
        }

    }
}