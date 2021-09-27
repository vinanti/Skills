using System;

namespace Coding_ABST03
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x, TreeNode left = null, TreeNode right = null)
        {
            val = x;
            this.left = left;
            this.right = right;
        }
    }
    class ABST03_InsertionIterative
    {
        static void Main03()
        {
            TreeNode root = new TreeNode(5, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(6, null, new TreeNode(7)));
            InsertIntoBST(root, 4);
        }
        public static TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);   // return a new node if root is null
            }
            if (root.val < val)
            {                           // insert to the right subtree if val > root->val
                root.right = InsertIntoBST(root.right, val);
            }
            else
            {                        // insert to the left subtree if val <= root->val
                root.left = InsertIntoBST(root.left, val);
            }
            return root;
        }
    }
}
