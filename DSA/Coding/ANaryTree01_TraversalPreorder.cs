using System;
using System.Collections.Generic;

namespace Coding_ANaryTree01
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
    class ANaryTree01_TraversalPreorder
    {
        static void Main01()
        {
            Node root = new Node(1,
                new List<Node>() {
                    new Node(3, new List<Node>() { new Node(5),new Node(6) }),
                    new Node(2, new List<Node>() { }),
                    new Node(4, new List<Node>() { })});
            Preorder(root);
        }
        public static List<int> Preorder(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            List<int> output = new List<int>();
            if (root == null)
            {
                return output;
            }

            stack.Push(root);
            while (stack.Count>0)
            {
                Node node = stack.Pop();
                output.Add(node.val);
                if(node.children != null)
                {
                    node.children.Reverse();
                    foreach (Node item in node.children)
                    {
                        stack.Push(item);
                    }
                }
            }
            return output;
        }
    }
}
