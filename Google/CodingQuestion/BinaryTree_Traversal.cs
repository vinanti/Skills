/*Binary Tree Preorder Traversal*/
using System;
using System.Collections.Generic;

namespace BinaryTree_NS
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
    public class Traversal
    {
        static List<int> list = new List<int>();
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null) return list;
            list.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
            return list;
        }
        public static IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null) return list;
            InorderTraversal(root.left);
            list.Add(root.val);
            InorderTraversal(root.right);
            return list;
        }
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null) return list;
            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            list.Add(root.val);
            return list;
        }
        static void MainBT()
        {
            TreeNode tree = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
            PreorderTraversal(tree); //1-2-3
            //InorderTraversal(tree); //1-3-2
            //PostorderTraversal(tree); //3-2-1

            foreach (var item in list)
                Console.Write(item + "-");
            Console.WriteLine();
        }
    }
}


