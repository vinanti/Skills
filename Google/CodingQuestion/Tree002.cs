/*Valid Binary Search Tree
 https://www.youtube.com/watch?v=i_Q0v_Ct5lY&list=PLI1t_8YX-Apv-UiRlnZwqqrRT8D1RhriX&index=7
 */

using System;

namespace Q304ns
{
    class Tree002
    {
        static void Main304(string[] args)
        {
            TreeNode p = new TreeNode(50);
            p.Insert(10);
            p.Insert(80);
            p.Insert(5);
            p.Insert(30);
            p.Insert(70);
            p.Insert(90);
            p.Insert(20);
            p.Insert(40);
            p.Insert(85);
            Console.WriteLine(CheckBST(p));
            
        }
        static bool CheckBST(TreeNode root)
        {
            return CheckBST(root, int.MinValue, int.MaxValue);
        }

        static bool CheckBST(TreeNode root, int min, int max)
        {
            if (root == null) return true;
            if (root.val <= min || root.val >= max) return false;
            return CheckBST(root.left, min, root.val-1) && CheckBST(root.right, root.val+1, max);
        }
    }
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
        public void Insert(int value)
        {
            if (value <= val)
            {
                if (left == null)
                    left = new TreeNode(value);
                else
                    left.Insert(value);
            }
            else
            {
                if (right == null)
                    right = new TreeNode(value);
                else
                    right.Insert(value);
            }
        }
    }
}
