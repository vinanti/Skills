using System;

namespace Coding_ABST04
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
    class ABST04_DeletionRecusive
    {
        static void Main04()
        {
            TreeNode root = new TreeNode(5, new TreeNode(2, new TreeNode(1), new TreeNode(4, new TreeNode(3))), new TreeNode(6, null, new TreeNode(7)));
            DeleteNode(root, 4);
        }
        /**
     * findSuccesor - Helper function for finding successor
     * In BST, succesor of root is the leftmost child in root's right subtree
     */
        private static TreeNode FindSuccessor(TreeNode root)
        {
            TreeNode cur = root.right;
            while (cur != null && cur.left != null)
            {
                cur = cur.left;
            }
            return cur;
        }
        public static TreeNode DeleteNode(TreeNode root, int key)
        {
            // return null if root is null
            if (root == null)
            {
                return root;
            }

            // delete current node if root is the target node
            if (root.val == key)
            {
                // replace root with root->right if root->left is null	
                if (root.left == null)
                {
                    return root.right;
                }

                // replace root with root->left if root->right is null
                if (root.right == null)
                {
                    return root.left;
                }

                // replace root with its successor if root has two children
                TreeNode p = FindSuccessor(root);
                root.val = p.val;
                root.right = DeleteNode(root.right, p.val);
                return root;
            }
            if (root.val < key)
            {
                // find target in right subtree if root->val < key
                root.right = DeleteNode(root.right, key);
            }
            else
            {
                // find target in left subtree if root->val > key
                root.left = DeleteNode(root.left, key);
            }
            return root;
        }
    }
}
