using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Q0104
{
    class Q0104
    {
        static void Main104()
        {
            TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            MaxDepth(root);
        }
        public static int MaxDepth(TreeNode root)
        {
            List<TreeNode> childs = new List<TreeNode>();
            if (root == null) return 0;
            int depth = 0;
            childs.Add(root);
            while (childs.Count > 0)
            {
                depth++;
                childs = GetChilds(childs);
            }
            return depth;
        }
        public static List<TreeNode> GetChilds(List<TreeNode> Nodes)
        {
            List<TreeNode> childs = new List<TreeNode>();
            foreach (TreeNode n in Nodes)
            {
                if (n.left != null) childs.Add(n.left);
                if (n.right != null) childs.Add(n.right);
            }
            return childs;
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
    }
}
