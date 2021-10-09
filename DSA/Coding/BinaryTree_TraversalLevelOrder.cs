using System;
using System.Collections.Generic;

namespace Coding_ABinaryTree03
{
    class BinaryTree_TraversalLevelOrder
    {
        static void Main()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            TreeNode chield = new TreeNode(20);
            chield.left = new TreeNode(15);
            chield.right = new TreeNode(7);
            root.right = chield;
            LevelOrder(root);
        }
        public static List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> ans = new List<List<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            if (root != null)
            {
                q.Enqueue(root);
            }
            TreeNode cur;
            while (q.Count > 0)
            {
                int size = q.Count;
                List<int> subAns = new List<int>();
                for (int i = 0; i < size; ++i)
                {        // traverse nodes in the same level
                    cur = q.Dequeue();
                    subAns.Add(cur.val);                // visit the root
                    if (cur.left != null)
                    {
                        q.Enqueue(cur.left);              // push left child to queue if it is not null
                    }
                    if (cur.right != null)
                    {
                        q.Enqueue(cur.right);             // push right child to queue if it is not null
                    }
                }
                ans.Add(subAns);
            }
            return ans;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
