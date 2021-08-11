/*100. Same Tree
https://leetcode.com/problems/same-tree/
Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
 

Example 1:
Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:

Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:

Input: p = [1,2,1], q = [1,1,2]
Output: false
 

Constraints:

The number of nodes in both trees is in the range [0, 100].
-104 <= Node.val <= 104*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q302ns
{
    class Q302
    {
        static void Main302(string[] args)
        {
            TreeNode p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            Console.WriteLine(IsSameTree(p, q));

            TreeNode p2 = new TreeNode(1, new TreeNode(2));
            TreeNode q2 = new TreeNode(1, null, new TreeNode(2));
            Console.WriteLine(IsSameTree(p2, q2));

            TreeNode p3 = new TreeNode(1, new TreeNode(2), new TreeNode(1));
            TreeNode q3 = new TreeNode(1, new TreeNode(1), new TreeNode(1));
            Console.WriteLine(IsSameTree(p2, q2));
        }

        static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (q == null || p == null) return false;
            if (p.val != q.val) return false;
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }

 
 // Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
}
