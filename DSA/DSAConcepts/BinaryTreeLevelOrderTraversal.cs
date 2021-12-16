using System;
using System.Collections.Generic;


namespace DSAConcepts
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val, TreeNode left=null, TreeNode right=null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class BinaryTreeLevelOrderTraversal
    {
        static void Main01()
        {
            TreeNode tree1 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            LevelOrderTraversal(tree1);
        }
        public static List<List<int>> LevelOrderTraversal(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(root != null) queue.Enqueue(root);
            while(queue.Count>0)
            {
                int levelNodes = queue.Count;
                List<int> subResult = new List<int>();
                while (levelNodes>0)
                {
                    TreeNode treeNode = queue.Dequeue();
                    subResult.Add(treeNode.val);
                    if (treeNode.left != null) queue.Enqueue(treeNode.left);
                    if (treeNode.right != null) queue.Enqueue(treeNode.right);
                    levelNodes--;
                }
                result.Add(subResult);
            }
            return result;
        }
    }
}
