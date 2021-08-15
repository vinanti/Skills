/*98. Validate Binary Search Tree
 https://leetcode.com/problems/validate-binary-search-tree/

Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
 

Example 1:


Input: root = [2,1,3]
Output: true
Example 2:


Input: root = [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
-231 <= Node.val <= 231 - 1*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q303ns
{
    class Q303
    {
        static void Main303(string[] args)
        {
            TreeNode p = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            Console.WriteLine(IsValidBST(p));

            TreeNode p2 = new TreeNode(1, new TreeNode(2));
            Console.WriteLine(IsValidBST(p2));

            TreeNode p3 = new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6)));
            Console.WriteLine(IsValidBST(p3));

            TreeNode p4 = new TreeNode(50, new TreeNode(10), new TreeNode(80, new TreeNode(70), new TreeNode(90)));
            Console.WriteLine(IsValidBST(p4));
        }
        static bool IsValidBST(TreeNode root)
        {
            return valid(root, null, null);
        }

        static bool valid(TreeNode root, TreeNode min, TreeNode max)
        {
            if (root == null) return true;
            if (min != null && root.val <= min.val) return false;
            if (max != null && root.val >= max.val) return false;
            return valid(root.left, min, root) && valid(root.right, root, max);
        }
    }
    // Definition for a binary tree node.
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
}
