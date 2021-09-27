using System;
using System.Collections.Generic;

namespace Coding_Q0589
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    class Q0589
    {
        static List<int> list = new List<int>();
        public static IList<int> Preorder(Node root)
        {
            if (root == null) return new List<int>();
            list.Add(root.val);
            if (root.children != null)
                foreach (Node child in root.children)
                    Preorder(child);
            return list;
        }
        static void Main589()
        {
            Node root = new Node(1,
                new List<Node>() {
                    new Node(3, new List<Node>() { new Node(5),new Node(6) }),
                    new Node(2, new List<Node>() { }),
                    new Node(4, new List<Node>() { })});
            Preorder(root);
        }
    }
}
