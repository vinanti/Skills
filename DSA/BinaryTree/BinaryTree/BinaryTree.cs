using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeNS
{
    public class Node
    {
        public int Data;
        public Node Left = null;
        public Node Right = null;
    }
    public class BinaryTree
    {
        public Node root = null;
        public void Insert(int data)
        {
            Node current = new Node();
            current.Data = data;

            if (root == null)
            {
                root = current;
                return;
            }
            Insert(root, current);
        }

        private void Insert(Node _root, Node newNode)
        {
            if (_root == null) return;

            if (newNode.Data < _root.Data)
            {
                if (_root.Left == null)
                {
                    _root.Left = newNode;
                }
                else
                {
                    Insert(_root.Left, newNode);
                }
            }
            else
            {
                if (_root.Right == null)
                {
                    _root.Right = newNode;
                }
                else
                {
                    Insert(_root.Right, newNode);
                }
            }
        }
        //Display Tree
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            this.DisplayTree(root);
        }
        //Search Node
        private Node Contains(Node root, int data)
        {
            if (root == null) return null;

            if (root.Data == data) return root;

            if (root.Data >= data)
            {

                return Contains(root.Left, data);
            }
            else
            {

                return Contains(root.Right, data);
            }
        }
        public Node Contains(int data)
        {
            return Contains(root, data);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bst = new BinaryTree();
            bst.Insert(15);
            bst.Insert(10);
            bst.Insert(24);
            bst.Insert(5);
            bst.Insert(22);
            bst.Insert(12);
            bst.Insert(30);
            bst.Insert(11);
            bst.Insert(5);
            bst.DisplayTree();

            bst.Contains(31);

            Console.Read();
        }
    }
}
