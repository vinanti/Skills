using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Q0701
{
    class TreeNode
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
    class Q0701
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            TreeNode node = new TreeNode(val);
            if (root == null) root = node;
            if (val < root.val)
            {
                if (root.left == null) root.left = node;
                else InsertIntoBST(root.left, val);
            }
            else
            {
                if (root.right == null) root.right = node;
                else InsertIntoBST(root.right, val);
            }
            return root;
        }
    }
}
