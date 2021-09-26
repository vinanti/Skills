using System;

namespace Coding_ABST05
{
    class ABST05_KthLargestElement
    {
        static void Main05()
        {
            KthLargest kthLargest = new KthLargest(3, new int[] { 4, 5, 8, 2 });
            kthLargest.Add(3);   // return 4
            kthLargest.Add(5);   // return 5
            kthLargest.Add(10);  // return 5
            kthLargest.Add(9);   // return 8
            kthLargest.Add(4);   // return 8
        }
    }
    class KthLargest
    {
        // insert a node into the BST
        private Node InsertNode(Node root, int num)
        {
            if (root == null)
            {
                return new Node(num, 1);
            }
            if (root.val < num)
            {
                root.right = InsertNode(root.right, num);
            }
            else
            {
                root.left = InsertNode(root.left, num);
            }
            root.cnt++;
            return root;
        }

        private int searchKth(Node root, int k)
        {
            // m = the size of right subtree
            int m = root.right != null ? root.right.cnt : 0;
            // root is the m+1 largest node in the BST
            if (k == m + 1)
            {
                return root.val;
            }
            if (k <= m)
            {
                // find kth largest in the right subtree
                return searchKth(root.right, k);
            }
            else
            {
                // find (k-m-1)th largest in the left subtree
                return searchKth(root.left, k - m - 1);
            }
        }

        private Node root;
        private int m_k;

        public KthLargest(int k, int[] nums)
        {
            root = null;
            for (int i = 0; i < nums.Length; ++i)
            {
                root = InsertNode(root, nums[i]);
            }
            m_k = k;
        }

        public int Add(int val)
        {
            root = InsertNode(root, val);
            return searchKth(root, m_k);
        }
    }

    class Node
    {    // the structure for the tree node
        public Node left;
        public Node right;
        public int val;
        public int cnt;    // the size of the subtree rooted at the node
        public Node(int v, int c)
        {
            left = null;
            right = null;
            val = v;
            cnt = c;
        }
    }
}
