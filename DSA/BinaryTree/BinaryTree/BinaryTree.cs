using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBinaryTree
{
    public class Node<T>
    {
        public T data;
        public Node<T> leftNode = null;
        public Node<T> rightNode = null;
    }
    public class BinaryTree<T>
    {
        public Node<T> root = null;
        public void Add(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            //Add the root
            if(root == null)
            {
                root = newItem;
                return;
            }
            Add(root, newItem);
        }
        private void Add(Node<T> _root, Node<T> newItem)
        {
            if (_root == null) return;

            if(root.leftNode == null)
            {
                root.leftNode = newItem;
                return;
            }
            else if (root.rightNode == null)
            {
                root.rightNode = newItem;
                return;
            }
            else
            {
                Add(root.leftNode, newItem);
            }
        }
    }
    
}
