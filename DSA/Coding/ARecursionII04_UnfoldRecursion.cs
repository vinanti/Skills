using System;
using System.Collections.Generic;

namespace Coding
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x, TreeNode left = null, TreeNode right = null) { val = x; }
    }

    class ARecursionII04_UnfoldRecursion
    {
        static void Main04()
        {
            TreeNode p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            bool isSame = IsSameTreeByRecursion(p, q);
            bool isSameUnfold = IsSameTreeUnfoldRecursion(p, q);
        }
        public static bool IsSameTreeByRecursion(TreeNode p, TreeNode q)
        {
            // p and q are both null
            if (p == null && q == null) return true;
            // one of p and q is null
            if (q == null || p == null) return false;
            if (p.val != q.val) return false;
            return IsSameTreeByRecursion(p.right, q.right) &&
                    IsSameTreeByRecursion(p.left, q.left);
        }

        public static bool Check(TreeNode p, TreeNode q)
        {
            // p and q are null
            if (p == null && q == null) return true;
            // one of p and q is null
            if (q == null || p == null) return false;
            if (p.val != q.val) return false;
            return true;
        }

        public static bool IsSameTreeUnfoldRecursion(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (!Check(p, q)) return false;
            // init deques
            List<TreeNode> deqP = new List<TreeNode>();
            List<TreeNode> deqQ = new List<TreeNode>();
            deqP.Add(p);
            deqQ.Add(q);

            while (deqP.Count>0)
            {
                //p = deqP.Remove();
                //q = deqQ.Remove();

                //if (!Check(p, q)) return false;
                //if (p != null)
                //{
                //    // in Java nulls are not allowed in Deque
                //    if (!Check(p.left, q.left)) return false;
                //    if (p.left != null)
                //    {
                //        deqP.addLast(p.left);
                //        deqQ.addLast(q.left);
                //    }
                //    if (!Check(p.right, q.right)) return false;
                //    if (p.right != null)
                //    {
                //        deqP.addLast(p.right);
                //        deqQ.addLast(q.right);
                //    }
                //}
            }
            return true;
        }
    }
}
