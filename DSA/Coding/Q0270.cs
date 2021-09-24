using System;

namespace Coding
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
    class Q0270
    {
        static void Main270()
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(2));
            ClosestValue(root, 3.428571);
        }
        //Approach 2
        public static int ClosestValue(TreeNode root, double target)
        {
            int val, closest = root.val;
            while (root != null)
            {
                val = root.val;
                closest = Math.Abs(val - target) < Math.Abs(closest - target) ? val : closest;
                root = target < root.val ? root.left : root.right;
            }
            return closest;
        }
        //Approach 1
        public static int ClosestValue01(TreeNode root, double target)
        {
            if (root == null) return 0;
            if (target < root.val)
            {
                TreeNode leftNode = root.left;
                if (leftNode != null && target > leftNode.val)
                {
                    if ((double)root.val - target < target - (double)leftNode.val)
                        return root.val;
                    else
                        return leftNode.val;
                }
                else
                {
                    ClosestValue(leftNode, target);
                }
            }
            else if (target > root.val)
            {
                TreeNode rightNode = root.right;
                if (rightNode != null && target < rightNode.val)
                {
                    if (target - (double)root.val < (double)rightNode.val - target)
                        return root.val;
                    else
                        return rightNode.val;
                }
                else
                {
                    ClosestValue(rightNode, target);
                }
            }
            return root.val;
        }
    }
}
