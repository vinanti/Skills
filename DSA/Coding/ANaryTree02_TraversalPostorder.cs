using System;
using System.Collections.Generic;

namespace Coding_ANaryTree02
{
    // Definition for a Node.
    class Node
    {
        public int val;
        public List<Node> children;

        public Node() { }

        public Node(int _val, List<Node> _children = null)
        {
            val = _val;
            children = _children;
        }
    };
    class ANaryTree02_TraversalPostorder
    {
        static void Main02()
        {
            Node root = new Node(1,
                new List<Node>() {
                    new Node(3, new List<Node>() { new Node(5),new Node(6) }),
                    new Node(2, new List<Node>() { }),
                    new Node(4, new List<Node>() { })});
            Postorder(root);
        }
        public static List<int> Postorder(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            List<int> output = new List<int>();
            if (root == null)
            {
                return output;
            }

            stack.Push(root);
            while (stack.Count > 0)
            {
                Node node = stack.Pop();
                output.Add(node.val);
                if (node.children != null)
                {
                    foreach (Node item in node.children)
                    {
                        if (item != null)
                        {
                            stack.Push(item);
                        }
                    }
                }
            }
            output.Reverse();
            return output;
        }
    }
}
