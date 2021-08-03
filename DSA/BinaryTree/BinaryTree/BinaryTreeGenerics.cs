using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeGenericsns  
{
    class BinaryTreeGenerics
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
            public void Insert(T data)
            {
                Node<T> current = new Node<T>();
                current.data = data;

                if (root == null)
                {
                    root = current;
                    return;
                }
                Insert(root, current);
            }


            private void Insert(Node<T> _root, Node<T> newItem)
            {
                if (_root == null) return;

                //if ((object)(_root.data) > (object)newItem.data)
                //{

                //}


                if (root.leftNode == null)
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
                    Insert(root.leftNode, newItem);
                }
            }
        }
    }
}
